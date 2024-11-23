using Couriermanagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriermanagement.Service
{
        public interface ICourierAdminService
        {
            // Add a new courier staff member to the system
            int AddCourierStaff(Employee employee);
        }
    }


