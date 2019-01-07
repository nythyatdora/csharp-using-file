using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Using_File
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void ResizeListView ()
        {
            for (int i = 0; i < List_Table.Columns.Count; i++)
                List_Table.Columns[i].Width = List_Table.Size.Width / 4;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private TextBox[] GetTextBoxes()
        {
            var textBoxes = new List<TextBox>();
            foreach(Control control in tableLayoutPanel_Input.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBoxes.Add(textBox);
                }
            }
            return textBoxes.ToArray();
        }

        private bool HasFilled(TextBox[] textBoxes)
        {
            bool hasAllFilled = true;
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    hasAllFilled = false;
                    break;
                }
            }
            return hasAllFilled;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (HasFilled(GetTextBoxes())) // all textboxes are filled
            {
                var id = Text_Product_ID.Text;
                var name = Text_Product_Name.Text;
                var price = Text_Product_Price.Text;
                var quantity = Text_Product_Quantity.Text;

                var row = new ListViewItem(id);
                row.SubItems.Add(name);
                row.SubItems.Add(price);
                row.SubItems.Add(quantity);
                row.SubItems.Add("true");

                List_Table.Items.Add(row);

                MessageBox.Show("Data has been added!","Message");

                ClearTextFields();
            }
        }

        private bool HasSelectedItem()
        {
            return List_Table.SelectedIndices.Count != 0;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (HasSelectedItem())
            {
                var item = List_Table.SelectedItems[0]; // select only one item that being focused on
                List_Table.Items.Remove(item);

                MessageBox.Show("Selected item has been deleted!", "Message");
            }
        }

        private void ClearTextFields()
        {
            foreach (Control control in tableLayoutPanel_Input.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void List_Table_DoubleClick(object sender, EventArgs e)
        {
            var item = List_Table.SelectedItems[0];
            if (item != null)
            {
                Text_Product_ID.Text = item.SubItems[Column_ID.DisplayIndex].Text;
                Text_Product_Name.Text = item.SubItems[Column_Name.DisplayIndex].Text;
                Text_Product_Price.Text = item.SubItems[Column_Price.DisplayIndex].Text;
                Text_Product_Quantity.Text = item.SubItems[Column_Quantity.DisplayIndex].Text;
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            if (HasFilled(GetTextBoxes()))
            {
                var id = Text_Product_ID.Text;
                var newName = Text_Product_Name.Text;
                var newPrice = Text_Product_Price.Text;
                var newQuantity = Text_Product_Quantity.Text;

                foreach (ListViewItem item in List_Table.Items)
                {
                    // check the input id
                    if (item.SubItems[Column_ID.DisplayIndex].Text == id)
                    {
                        item.SubItems[Column_Name.DisplayIndex].Text = newName;
                        item.SubItems[Column_Price.DisplayIndex].Text = newPrice;
                        item.SubItems[Column_Quantity.DisplayIndex].Text = newQuantity;

                        break;
                    }
                }
            }
        }

        private string GetJSONValue(String obj, String key)
        {
            obj = obj.Substring(1, obj.Length - 2); // remove '}' and ','
            String[] attributes = obj.Split(',');
            string f_value = "";

            foreach(String str in attributes)
            {
                String f_key = str.Trim().Split(':')[0];
                if(f_key == key)
                {
                    return str.Trim().Split('"')[1];
                }
            }
            return f_value;
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            List_Table.Items.Clear();
            using (FileStream fileStream = new FileStream("ProductList.txt", FileMode.Open))
            {
                using (StreamReader streamRead = new StreamReader(fileStream))
                {
                    while(!streamRead.EndOfStream)
                    {
                        String items = streamRead.ReadLine();

                        var id = GetJSONValue(items, "ID");
                        var name = GetJSONValue(items, "Name");
                        var price = GetJSONValue(items, "Price");
                        var quantity = GetJSONValue(items, "Quantity");

                        var item = new ListViewItem(id);
                        item.SubItems.Add(name);
                        item.SubItems.Add(price);
                        item.SubItems.Add(quantity);
                        item.SubItems.Add("false");

                        List_Table.Items.Add(item);
                    }

                    MessageBox.Show("Read completed!","Message");
                }
            }
        }

        private void WriteToFile()
        {
            using (FileStream fileStream = new FileStream("ProductList.txt", FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (ListViewItem item in List_Table.Items)
                    {
                        var product = new Product()
                        {
                            ID = Convert.ToInt16(item.SubItems[Column_ID.DisplayIndex].Text),
                            Name = item.SubItems[Column_Name.DisplayIndex].Text,
                            Price = Convert.ToDouble(item.SubItems[Column_Price.DisplayIndex].Text),
                            Quantity = Convert.ToInt16(item.SubItems[Column_Quantity.DisplayIndex].Text)
                        };

                        streamWriter.WriteLine(product.ToJSON());
                    }
                }
            }
        }

        private void Button_Write_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to write a new file?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch(result)
            {
                case DialogResult.Yes:
                    WriteToFile();
                    break;

                case DialogResult.No:
                    MessageBox.Show("Cancel!", "Message");
                    break;
            }
        }

        private void AppendToFile()
        {
            using (FileStream fileStream = new FileStream("ProductList.txt", FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    // append only those have recently added
                    foreach (ListViewItem item in List_Table.Items)
                    {
                        if (item.SubItems[Column_IsNew.DisplayIndex].Text == "true")
                        {
                            var product = new Product()
                            {
                                ID = Convert.ToInt16(item.SubItems[Column_ID.DisplayIndex].Text),
                                Name = item.SubItems[Column_Name.DisplayIndex].Text,
                                Price = Convert.ToDouble(item.SubItems[Column_Price.DisplayIndex].Text),
                                Quantity = Convert.ToInt16(item.SubItems[Column_Quantity.DisplayIndex].Text)
                            };

                            streamWriter.WriteLine(product.ToJSON());
                        }
                    }
                }
            }
        }

        private void Button_Append_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to append new data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    AppendToFile();
                    break;

                case DialogResult.No:
                    MessageBox.Show("Cancel!", "Message");
                    break;
            }
        }

        private void Button_Clear_Table_Click(object sender, EventArgs e)
        {
            List_Table.Items.Clear();
        }
    }
}
