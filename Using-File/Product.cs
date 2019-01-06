using System;

namespace Using_File
{
    public partial class Form_Main
    {
        public class Product
        {
            public int ID { set; get; }
            public String Name { set; get; }
            public Double Price { set; get; }
            public int Quantity { set; get; }

            public string ToJSON()
            {
                String temp = "{\t";
                temp += "ID: " +  "\"" + ID + "\"" + ",\t";
                temp += "Name: " + "\"" + Name + "\"" + ",\t";
                temp += "Price: " + "\"" + Price + "\"" + ",\t";
                temp += "Quantity: " + "\"" + Quantity + "\"" + "\t},";
                return temp;
            }
        }
    }
}
