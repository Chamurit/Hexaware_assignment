

namespace Task2_5
{
  
        public class Courier
        {
            public int CourierID { get; set; }
            public string SenderName { get; set; }
            public string SenderAddress { get; set; }
            public string ReceiverName { get; set; }
            public string ReceiverAddress { get; set; }
            public decimal Weight { get; set; }
            public string Status { get; set; }
            public string TrackingNumber { get; set; }
            public DateTime DeliveryDate { get; set; }

            public Courier(int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, decimal weight, string status, string trackingNumber, DateTime deliveryDate)
            {
                CourierID = courierID;
                SenderName = senderName;
                SenderAddress = senderAddress;
                ReceiverName = receiverName;
                ReceiverAddress = receiverAddress;
                Weight = weight;
                Status = status;
                TrackingNumber = trackingNumber;
                DeliveryDate = deliveryDate;
            }
        }
    }



