using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Exceptions
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(string message) : base(message) 
        {
        }
    }
}
