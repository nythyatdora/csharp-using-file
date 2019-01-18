using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_File
{
    class Order
    {
        public string ID { set; get; }
        public Dictionary<string, OrderDetail> Details { set; get; }

        public Order()
        {
            Details = new Dictionary<string, OrderDetail>();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            Details.Add(orderDetail.Product.ID, orderDetail);
        }

        public string ToJSON()
        {
            string obj = "{ ";
            obj += $"\"ID\" : \"{ID}\", ";

            foreach (KeyValuePair<string, OrderDetail> keyValuePairDetail in Details)
            {
                var key = keyValuePairDetail.Key;
                var value = keyValuePairDetail.Value;
                if (value == Details.Values.ElementAt(0))
                {
                    obj += $"\"OrderDetail\" : [{Details[key].ToJSON()} ";
                }
                else
                {
                    obj += $"{Details[key].ToJSON()} ";
                }
            }

            obj += "], },";

            return obj;
        }
    }
}
