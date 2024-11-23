using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriermanagement.Service
{  public class Courier
        {
            private static int trackingNumberCounter = 1000; // Example starting value
            private int courierID;
            private string senderName;
            private string senderAddress;
            private string receiverName;
            private string receiverAddress;
            private decimal weight;
            private string status;
            private string trackingNumber;
            private DateTime deliveryDate;
            private int userId;

            // Default constructor
            

            // Parameterized constructor
            public Courier(int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, decimal weight, string status, DateTime deliveryDate, int userId)
            {
                this.courierID = courierID;
                this.senderName = senderName;
                this.senderAddress = senderAddress;
                this.receiverName = receiverName;
                this.receiverAddress = receiverAddress;
                this.weight = weight;
                this.status = status;
                this.trackingNumber = GenerateTrackingNumber();
                this.deliveryDate = deliveryDate;
                this.userId = userId;
            }

            // Generate a unique tracking number
            private string GenerateTrackingNumber()
            {
                return (trackingNumberCounter++).ToString("D10"); // 10-digit tracking number
            }

            // Getters and Setters
            public int CourierID { get => courierID; set => courierID = value; }
            public string SenderName { get => senderName; set => senderName = value; }
            public string SenderAddress { get => senderAddress; set => senderAddress = value; }
            public string ReceiverName { get => receiverName; set => receiverName = value; }
            public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
            public decimal Weight { get => weight; set => weight = value; }
            public string Status { get => status; set => status = value; }
            public string TrackingNumber { get => trackingNumber; }
            public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
            public int UserId { get => userId; set => userId = value; }

            // ToString method
            public override string ToString()
            {
                return $"CourierID: {courierID}, SenderName: {senderName}, ReceiverName: {receiverName}, Weight: {weight}, Status: {status}, TrackingNumber: {trackingNumber}, DeliveryDate: {deliveryDate}, UserID: {userId}";
            }
        }
    }

