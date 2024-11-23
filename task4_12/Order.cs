using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_12
{
    public class Order
    {
        public string CustomerName { get; set; }
        public string OrderNumber { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public Order(string customerName, string orderNumber, string deliveryAddress, DateTime expectedDeliveryDate)
        {
            CustomerName = customerName;
            OrderNumber = orderNumber;
            DeliveryAddress = deliveryAddress;
            ExpectedDeliveryDate = expectedDeliveryDate;

        }
    }

}
