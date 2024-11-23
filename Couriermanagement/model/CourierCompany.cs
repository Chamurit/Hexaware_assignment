using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriermanagement.model
{
        public class CourierCompany
        {
            private string companyName;
            private List<Courier> courierDetails;
            private List<Employee> employeeDetails;
            private List<Location> locationDetails;

          

            // Parameterized constructor
            public CourierCompany(string companyName, List<Courier> courierDetails, List<Employee> employeeDetails, List<Location> locationDetails)
            {
                this.companyName = companyName;
                this.courierDetails = courierDetails;
                this.employeeDetails = employeeDetails;
                this.locationDetails = locationDetails;
            }

            // Getters and Setters
            public string CompanyName { get => companyName; set => companyName = value; }
            public List<Courier> CourierDetails { get => courierDetails; set => courierDetails = value; }
            public List<Employee> EmployeeDetails { get => employeeDetails; set => employeeDetails = value; }
            public List<Location> LocationDetails { get => locationDetails; set => locationDetails = value; }

            // toString method
            public override string ToString()
            {
                return $"CompanyName: {companyName}, Number of Couriers: {courierDetails.Count}, Number of Employees: {employeeDetails.Count}, Number of Locations: {locationDetails.Count}";
            }
        }
    }

