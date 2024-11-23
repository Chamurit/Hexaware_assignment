using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriermanagement.Service
{
        public interface ICourierUserService
        {
            // Place a new courier order
            string PlaceOrder(Courier courierObj);

            // Get the status of a courier order
            string GetOrderStatus(string trackingNumber);

            // Cancel a courier order
            bool CancelOrder(string trackingNumber);

            // Get a list of orders assigned to a specific courier staff member
            List<Courier> GetAssignedOrder(int courierStaffId);
        }
    }

