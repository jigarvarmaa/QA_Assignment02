using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                int length;
                int width;

                Console.WriteLine("Enter the length of a Rectangle: ");

                while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Enter value greater than 0: ");
                }

                Console.WriteLine("Enter the width of a Rectangle: ");

                while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.WriteLine("Enter value greater than 0: ");
                }

                do
                {
                    input = Menu();

                    Rectangle rectangle = new Rectangle();

                    rectangle.GetCurrentLength();
                    rectangle.SetNewLength(length);

                    rectangle.GetCurrentWidth();
                    rectangle.SetNewWidth(width);

                    if (input == 1)
                    {
                        Console.WriteLine("The length of Rectangle is: ");
                        Console.WriteLine(rectangle.GetCurrentLength());
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Length of Rectangle: ");
                        while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                        {
                            Console.WriteLine("Enter the value greater than 0: ");
                        }
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("The width of Rectangle is: ");
                        Console.WriteLine(rectangle.GetCurrentWidth());
                    }
                    else if (input == 4)
                    {
                        Console.WriteLine("Width of Rectangle: ");
                        while ((!int.TryParse(Console.ReadLine(), out width)) || width == 0)
                        {
                            Console.WriteLine("Enter the value greater than 0: ");
                        }
                    }
                    else if (input == 5)
                    {
                        Console.WriteLine("Perimeter of Rectangle: ");
                        Console.WriteLine(rectangle.GetPerimeter());
                    }
                    else if (input == 6)
                    {
                        Console.WriteLine("Area of Rectangle: ");
                        Console.WriteLine(rectangle.GetArea());
                    }
                    else if (input == 7)
                    {
                        Environment.Exit(0);
                    }
                }
                while (input < 7);
                {
                    Console.WriteLine("Choose proper number");
                    Menu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int Menu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("\n 1: Get Rectangle Length");
            Console.WriteLine("\n 2: Change Rectangle Length");
            Console.WriteLine("\n 3: Get Rectangle Width");
            Console.WriteLine("\n 4: Change Rectangle Width");
            Console.WriteLine("\n 5: Get Rectangle Perimeter");
            Console.WriteLine("\n 6: Get Rectangle Area");
            Console.WriteLine("\n 7: Exit");

            return int.Parse(Console.ReadLine());

        }
    }
}