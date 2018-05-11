using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            double output;
            string operat;
            double input1;
            double input2;
            int t = 1;

            while (t > 0) {
                
                Console.WriteLine("Input First Number: ");
                input1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter operator ( * / + - ^ )");
                operat = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Input Second Number: ");
                input2 = double.Parse(Console.ReadLine());
                switch (operat)
                {
                    case "*":
                        output = input1 * input2;
                        Console.Clear();
                        Console.WriteLine(output);
                        break;
                    case "/":
                        output = input1 / input2;
                        Console.Clear();
                        Console.WriteLine(output);
                        break;
                    case "+":
                        output = input1 + input2;
                        Console.Clear();
                        Console.WriteLine(output);
                        break;
                    case "-":
                        output = input1 - input2;
                        Console.Clear();
                        Console.WriteLine(output);
                        break;
                    case "^":
                        output = Math.Pow(input1, input2);
                        Console.Clear();
                        Console.WriteLine(output);
                        break;
                }
            }
        }
    }
}
