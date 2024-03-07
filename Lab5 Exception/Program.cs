using System;
using System.Runtime.CompilerServices;

namespace Lab5_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Radius value of the circle
            Circle Radius1 = new Circle(1);
            Circle Radius2 = new Circle(-10);
            Circle Radius3 = new Circle(0);
    



            //Prints the radius value that are set
            Radius1.toString();
            Radius2.toString();
            Radius3.toString();





        }
    }
}
