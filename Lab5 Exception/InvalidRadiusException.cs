using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Exception
{
    public class InvalidRadiusException : Exception
    {
        //Default message
        public InvalidRadiusException() : base($"Invalid radius: less than or equal to 0!!")
        {
        }
        //Error message with Radius
        public InvalidRadiusException(double Radius) :base($"Invalid radius: {Radius}, less than or equal to 0!!")
        {
        }
    }
}
