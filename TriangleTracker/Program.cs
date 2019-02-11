using System;

namespace Triangle
{
    public class Program
    {
        public static void Main()
        {
            ThreeSideObject newTriangle = new ThreeSideObject();
            newTriangle.SetSides();

            if(newTriangle.IsNotATriangle())
            {
                Console.WriteLine("This is not a triangle");
            }
            else if(newTriangle.IsEquilateral())
            {
                Console.WriteLine("This is an equilateral triangle");
            }
            else if(newTriangle.IsIsosceles())
            {
                Console.WriteLine("This is an isoscelese triangle");
            }
            else if(newTriangle.IsScalene())
            {
                Console.WriteLine("This is a scalene triangle");
            }
            else
            {
                Console.WriteLine("Honestly I'm stumped on this one.");
            }

        }
    }
}