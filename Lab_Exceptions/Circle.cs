using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Exceptions
{
    public class Circle
    {
        private double Radius;
        public void SetRadius (double radius)
        {
            if (radius <= 0) 
            {
                throw new InvalidRadiusException("Radius must be greater than zero.");
            }
            else 
            {
                Radius = radius;
            }
        }
        public override string ToString()
        {
            return $"Radius of the circle is {Radius}";
        }
    }
}
