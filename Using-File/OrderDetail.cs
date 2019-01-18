namespace Using_File
{
    class OrderDetail
    {
        public Product Product { set; get; }
        public int Amount { set; get; }

        public OrderDetail()
        {

        }

        public string ToJSON()
        {
            string obj = "{ ";
            obj += $"\"Product\" : {Product.ToJSON()} ";
            obj += $"\"Amount\" : \"{Amount}\", ";
            obj += "},";

            return obj;
        }
    }
}