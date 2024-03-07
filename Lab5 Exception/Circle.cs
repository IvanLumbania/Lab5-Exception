using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Exception
{
    public class Circle
    {
        //Attritube of the circle Radius
        double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
            SetRadius();

        }

        //Checks the radius by using exceptions. 
        public void SetRadius()
        {
            try
            {
                if (Radius <= 0)
                {
                    throw new InvalidRadiusException(Radius);

                }
                Radius = this.Radius;
            }
            catch(InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        //displays the radius that is are set
        public void toString()
        {
            Console.WriteLine($"Radius: {this.Radius}");
        }
    }
}
