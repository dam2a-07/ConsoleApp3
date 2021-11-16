using System;
namespace ConsoleAppHijo
{
    using System;
    using System.Diagnostics;

    public class Program
    {


        public static double Operaciones(double num1, double num2, string op)
        {
            double result = double.NaN;
            Double vuelve = 0;

            switch (op)
            {
                case "s":
                    result = num1 + num2;
                    break;
                case "r":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":

                    if (num2 == 0)
                    {
                        Console.WriteLine("Division entre 0");
                        result = Double.NaN;
                    }
                    else { result = num1 / num2; }
                    break;
                default:
                    Console.WriteLine("Introduce una operacion 's' 'r' 'm' 'd'");
                    result = Double.NaN;
                    break;
            }
            Console.WriteLine("Resultado es: " + result);
            vuelve = result;
            return vuelve;
        }
        static void Main(string[] args)
        {

            try
            {
                string numeroarg1 = args[1];
                string numeroarg2 = args[2];
                string op = args[0];
                double result = 0;
                Double numerocalc1;
                Double numerocalc2;

                if (!Double.TryParse(numeroarg1, out numerocalc1))
                {
                    Console.WriteLine("Introduce un numero valido");
                }
                else
                {
                    numerocalc1 = Double.Parse(numeroarg1);
                }

                if (!Double.TryParse(numeroarg2, out numerocalc2))
                {
                    Console.WriteLine("Introduce un numero valido");
                }
                else
                {
                    numerocalc2 = Double.Parse(numeroarg2);
                }

                result = Operaciones(numerocalc1, numerocalc2, op);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

