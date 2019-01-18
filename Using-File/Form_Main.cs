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
using Newtonsoft.Json;

namespace Using_File
{
    public partial class Form_Main : Form
    {
        private bool IsWritten = true;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void ResizeListView ()
        {
            for (int i = 0; i < ListView_Table.Columns.Count; i++)
                ListView_Table.Columns[i].Width = ListView_Table.Size.Width / 4;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ResizeListView();

            ReadFromFile();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsWritten)
            {
                var respond = MessageBox.Show("There is unsaved data.\nAre you sure, you want to discard?", 
                    "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                switch (respond)
                {
                    case DialogResult.Yes:
                        e.Cancel = false;
                        break;
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private TextBox[] GetTextBoxes()
        {
            var textBoxes = new List<TextBox>();
            foreach(Control control in TableLayoutPanel_Input.Controls)
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

                ListView_Table.Items.Add(row);

                IsWritten = false;

                MessageBox.Show("Data has been added!","Message");

                ClearTextFields();
            }
        }

        private bool  HasSelectedItem => ListView_Table.SelectedIndices.Count != 0;

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (HasSelectedItem)
            {
                var item = ListView_Table.SelectedItems[0];
                ListView_Table.Items.Remove(item);

                WriteToFile();

                MessageBox.Show("Selected item has been deleted!", "Message");
            }
        }

        private void ClearTextFields()
        {
            foreach (Control control in TableLayoutPanel_Input.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
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

                foreach (ListViewItem item in ListView_Table.Items)
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

                WriteToFile();
                ClearTextFields();

                MessageBox.Show("Data has been updated!", "Message");
            }
        }

        private void ReadFromFile()
        {
            ListView_Table.Items.Clear();

            try
            {
                using (var fileStream = new FileStream("ProductList.txt", FileMode.Open))
                {
                    using (var streamRead = new StreamReader(fileStream))
                    {
                        while (!streamRead.EndOfStream)
                        {
                            string obj = streamRead.ReadLine();

                            var product = JsonConvert.DeserializeObject<Product>(obj);

                            var item = new ListViewItem(product.ID);
                            item.SubItems.Add(product.Name);
                            item.SubItems.Add(product.Price.ToString());
                            item.SubItems.Add(product.Quantity.ToString());
                            item.SubItems.Add("false");

                            ListView_Table.Items.Add(item);
                        }

                        // MessageBox.Show("Read completed!","Message");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }

        private void Button_Read_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        private void WriteToFile()
        {
            using (var fileStream = new FileStream("ProductList.txt", FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    foreach (ListViewItem item in ListView_Table.Items)
                    {
                        var product = new Product()
                        {
                            ID = item.SubItems[Column_ID.DisplayIndex].Text,
                            Name = item.SubItems[Column_Name.DisplayIndex].Text,
                            Price = Convert.ToDouble(item.SubItems[Column_Price.DisplayIndex].Text),
                            Quantity = Convert.ToInt16(item.SubItems[Column_Quantity.DisplayIndex].Text)
                        };

                        var jsonProduct = JsonConvert.SerializeObject(product);

                        streamWriter.WriteLine(jsonProduct);
                    }

                    IsWritten = true;
                    // MessageBox.Show("Data has been written!", "Message");
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to save new data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    WriteToFile();
                    break;

                case DialogResult.No:
                    MessageBox.Show("Cancel!", "Message");
                    break;
            }
        }

        private void ListView_Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = ListView_Table.SelectedItems[0];
            if (item != null)
            {
                Text_Product_ID.Text = item.SubItems[Column_ID.DisplayIndex].Text;
                Text_Product_Name.Text = item.SubItems[Column_Name.DisplayIndex].Text;
                Text_Product_Price.Text = item.SubItems[Column_Price.DisplayIndex].Text;
                Text_Product_Quantity.Text = item.SubItems[Column_Quantity.DisplayIndex].Text;
            }
        }
    }
}
