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
    }
}
