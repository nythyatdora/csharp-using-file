using System;

namespace Using_File
{
    public class Product
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }

        public string ToJSON()
        {
            String obj = "{ ";
            obj += $"\"ID\" : \"{ID}\", ";
            obj += $"\"Name\" : \"{Name}\", ";
            obj += $"\"Price\" : \"{Price}\", ";
            obj += $"\"Quantity\" : \"{Quantity}\", ";
            obj += "},";

            return obj;
        }
    }
}
