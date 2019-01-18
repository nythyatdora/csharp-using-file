using System;

namespace Using_File
{
    [Serializable]
    public class Product
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }
    }
}
