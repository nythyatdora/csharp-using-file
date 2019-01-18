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
    public partial class Form_Sub_Main : Form
    {
        private bool IsWritten;
        private Dictionary<string, Product> Stocks = new Dictionary<string, Product>();
        private Dictionary<string, Order> Orders = new Dictionary<string, Order>();

        public Form_Sub_Main()
        {
            InitializeComponent();
            ResizeListView();

            IsWritten = true;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
        }

        private void ResizeListView ()
        {
            for (int i = 0; i < ListView_Table.Columns.Count; i++)
                ListView_Table.Columns[i].Width = ListView_Table.Size.Width / 6;
        }

        private void Form_Sub_Main_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void ReadProducts()
        {
            Combo_Product_ID.Items.Add("");
            try
            {
                using (var fileStream = new FileStream("ProductList.txt", FileMode.Open))
                {
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string obj = streamReader.ReadLine();

                            var product = JsonConvert.DeserializeObject<Product>(obj);

                            Stocks.Add(product.ID, product);
                            Combo_Product_ID.Items.Add(product.ID);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }
        }

        private void ReadFromOrder()
        {
            ListView_Table.Items.Clear();
            try
            {
                using (var fileStream = new FileStream("OrderList.txt", FileMode.Open))
                {
                    using (var streamRead = new StreamReader(fileStream))
                    {
                        while (!streamRead.EndOfStream)
                        {
                            var obj = streamRead.ReadLine();
                            var order = JsonConvert.DeserializeObject<Order>(obj);
                            Orders.Add(order.ID, order);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return;
            }

            UpdateListView();
        }
        
        private void Form_Sub_Main_Load(object sender, EventArgs e)
        {
            ReadProducts();
            ReadFromOrder();
        }

        private void ClearTextBox(TextBox textBox) => textBox.Text = string.Empty; 

        private void Combo_Product_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedItem = Combo_Product_ID.SelectedItem.ToString();

            if (selectedItem != "")
            {
                Text_Product_Name.Text = Stocks[selectedItem].Name;
                Text_Product_Price.Text = Stocks[selectedItem].Price.ToString();
                Text_Product_Quantity_In_Stock.Text = Stocks[selectedItem].Quantity.ToString();
            }
            else
            {
                ClearTextBox(Text_Product_Name);
                ClearTextBox(Text_Product_Price);
                ClearTextBox(Text_Product_Quantity_In_Stock);
            }
        }

        private void ClearAllFields()
        {
            foreach (Control control in TableLayoutPanel_Input.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void UpdateListView()
        {
            ListView_Table.Items.Clear();
            foreach (KeyValuePair<string, Order> valuePairOrder in Orders)
            {
                var order = valuePairOrder.Value;
                foreach (KeyValuePair<string, OrderDetail> valuePairDetail in order.Details)
                {
                    var detail = valuePairDetail.Value;
                    var item = new ListViewItem(order.ID);

                    item.SubItems.Add(detail.Product.ID);
                    item.SubItems.Add(detail.Product.Name);
                    item.SubItems.Add(detail.Product.Price.ToString());
                    item.SubItems.Add(detail.Amount.ToString());
                    ListView_Table.Items.Add(item);
                }
            }
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
                var orderId = Text_Order_ID.Text;
                var selectedProduct = Combo_Product_ID.SelectedItem.ToString();
                var product = Stocks[selectedProduct];
                var amount = Text_Amount.Text;

                var isOrdered = Orders.ContainsKey(orderId);

                if (!isOrdered)
                {
                    var orderDetail = new OrderDetail()
                    {
                        Product = product,
                        Amount = Convert.ToInt16(amount),
                    };

                    var order = new Order() {ID = orderId};
                    order.AddOrderDetail(orderDetail);

                    Orders.Add(order.ID, order);
                }
                else
                {
                    var hasProduct = Orders[orderId].Details.ContainsKey(selectedProduct);
                    if (!hasProduct)
                    {
                        var orderDetail = new OrderDetail()
                        {
                            Product = product,
                            Amount = Convert.ToInt16(amount),
                        };

                        Orders[orderId].AddOrderDetail(orderDetail);
                    }
                    else
                    {
                        Orders[orderId].Details[selectedProduct].Amount += Convert.ToInt16(amount);
                    }
                }

                IsWritten = false;
                UpdateListView();
                ClearAllFields();
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ClearAllFields();

            Button_Add.Enabled = true;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            var orderId = Text_Order_ID.Text;
            var selectedProduct = Combo_Product_ID.SelectedItem.ToString();

            Orders[orderId].Details.Remove(selectedProduct);

            UpdateListView();
            ClearAllFields();

            Button_Add.Enabled = true;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            var orderId = Text_Order_ID.Text;
            var newAmount = Text_Amount.Text;
            var selectedProduct = Combo_Product_ID.SelectedItem.ToString();

            Orders[orderId].Details[selectedProduct].Amount = Convert.ToInt16(newAmount);
            
            UpdateListView();
            ClearAllFields();

            Button_Add.Enabled = true;
            Button_Update.Enabled = false;
            Button_Delete.Enabled = false;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            using (var fileStream = new FileStream("OrderList.txt", FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream))
                { 
                    foreach (KeyValuePair<string, Order> valuePairOrder in Orders)
                    {
                        var order = valuePairOrder.Value;
                        var jsonOrder = JsonConvert.SerializeObject(order);
                        streamWriter.WriteLine(jsonOrder);
                    }

                    IsWritten = true;
                    MessageBox.Show("Data has been written!", "Message");
                }
            }
        }

        private void ListView_Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = ListView_Table.SelectedItems[0];
            if (item != null)
            {
                Text_Order_ID.Text = item.SubItems[Column_Order_ID.DisplayIndex].Text;

                var productId = item.SubItems[Column_Product_ID.DisplayIndex].Text;

                Combo_Product_ID.SelectedItem = productId;
                Text_Product_Name.Text = Stocks[productId].Name;
                Text_Product_Price.Text = Stocks[productId].Price.ToString();
                Text_Product_Quantity_In_Stock.Text = Stocks[productId].Quantity.ToString();
                Text_Amount.Text = item.SubItems[Column_Amount.DisplayIndex].Text;

                Button_Add.Enabled = false;
                Button_Update.Enabled = true;
                Button_Delete.Enabled = true;
            }
        }

        private void Form_Sub_Main_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
