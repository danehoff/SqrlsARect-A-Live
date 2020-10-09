using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrlsARect_A_Live
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            ///Square s1 = new Square();
            SquareSquare s1 = new SquareSquare();

            Console.WriteLine("Calling the funtion with Rectangle.");
            UserOfRectangle(r1);

            Console.WriteLine("Now, calling the function with a Square.");
            UserOfRectangle(s1);
            Console.ReadLine();

        }

        static void UserOfRectangle(Rectangle r)
        {

            r.Height = 4;
            r.Width = 5;

            if(r.CalculateArea() != 20)
            {
                throw new Exception("Bad Area! Bad, Bad Area!");
            }
            else
            {

                Console.Write("For the Shape with sides: " + r.Height + " by " + r.Width + ", ");
                Console.WriteLine("The Area is: " + r.CalculateArea());

            }

        }

    }
}
