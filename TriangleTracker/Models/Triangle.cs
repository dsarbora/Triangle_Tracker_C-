using System;

namespace Triangle
{
    class ThreeSideObject
    {
        public int A;
        public int B;
        public int C;

        public void SetSides()
        {
            Console.WriteLine("Enter side A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C");
            C = int.Parse(Console.ReadLine());

        }

        public bool IsEquilateral()
        {
            if(A==B && B==C)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsIsosceles()
        {   
            if(!IsNotATriangle() && !IsEquilateral())
            {
                if((A==B|| (A==C)|| (B==C)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public bool IsScalene()
        {
            if(!IsNotATriangle())
            {
                if(!(A==B) && !(B==C))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool IsNotATriangle()
        {
            if((A>B+C) || (B>A+C) || (C>A+B) ||A<0||B<0||C<0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}