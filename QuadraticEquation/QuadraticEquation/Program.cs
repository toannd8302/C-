using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class Program
    {



        
        static void Main(string[] args)
        {
            int a, b, c;
            String inputA, inputB, inputC;
            double delta, x1, x2;
            bool isValid = false;
            Console.WriteLine("Welcome to Quadratic Equation Calculation");



            while (!isValid)
            {
                try
                {
                    Console.Write("Input a = ");
                    inputA = Console.ReadLine();
                    if (inputA == null)
                    {
                        throw new Exception("Pls input A");
                    }
                    a = Convert.ToInt32(inputA);
                    if (a == 0 )
                    {
                        throw new Exception("a not be 0");

                    }
                    if(a > Int32.MaxValue || a< Int32.MinValue)
                    {
                        throw new Exception("Out range");
                    }
                    Console.Write("Input b = ");
                    inputB = Console.ReadLine();
                    if (inputB == null)
                    {
                        throw new Exception("Pls input B");
                    }
                    b = Convert.ToInt32(inputB);

                    if (b > Int32.MaxValue || b < Int32.MinValue)
                    {
                        throw new Exception("Out range");
                    }
                    Console.Write("Input c = ");
                    inputC = Console.ReadLine();
                    if (inputC == null)
                    {
                        throw new Exception("Pls input C");
                    }
                    c = Convert.ToInt32(inputC);
                    if (c > Int32.MaxValue || c < Int32.MinValue)
                    {
                        throw new Exception("Out range");
                    }
                    delta = (b * b - 4 * a * c);
                    if (delta > 0)
                    {
                        Console.WriteLine("Phương trình có 2 nghiệm phân biệt");
                        x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                        x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                        Console.WriteLine("x1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                    }
                    else if (delta == 0)
                    {
                        Console.WriteLine("Phương trình có nghiệm kép");
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("x1=x2= " + x1);
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm");
                    }
                     isValid = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                Console.ReadKey(); // dừng màn hình


            }
        }
    }
}

