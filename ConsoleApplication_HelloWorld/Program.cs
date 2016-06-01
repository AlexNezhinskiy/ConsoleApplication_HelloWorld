using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myDataType = System.Int32;

namespace ConsoleApplication_HelloWorld
{
    class Program
    {
        static void Main()
        {
            bool a;
            int X=2;
                if ((X > 1) && (!(X < 5) && (X < 3)))
                    Console.WriteLine("1. true");
                else
                {
                    Console.WriteLine("false");
                }
                if ((X % X > 1) || (X / X < X % X + 1))
                    Console.WriteLine("2. true");
                else
                {
                    Console.WriteLine("false");
                }
                if ((X <= 2) || (X % 2 + 1 != 2) && (X == 2 && X < 4))
                Console.WriteLine("3. true");
                    else
                    {
                        Console.WriteLine("false");
                    }
                if ((X * X != 2 / X + 2) && (X < 1))
                Console.WriteLine("4. true");
                    else
                    {
                        Console.WriteLine("false");
                    }

            Console.ReadKey();
        }
    }
}
