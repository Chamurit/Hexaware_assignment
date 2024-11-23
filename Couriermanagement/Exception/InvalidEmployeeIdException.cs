using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couriermanagement.Exception
{
   
        public class InvalidEmployeeIdException : IOException
        {
            public InvalidEmployeeIdException(string message) : base(message) { }
        }
}

