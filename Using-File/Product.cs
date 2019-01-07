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
                String obj = "{\t";
                obj += $"ID: \"{ID}\",\t";
                obj += $"Name: \"{Name}\",\t";
                obj += $"Price: \"{Price}\",\t";
                obj += $"Quantity: \"{Quantity}\",\t";
                obj += "},";

                return obj;
            }
        }
    }
}
