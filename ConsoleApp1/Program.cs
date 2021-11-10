﻿using System;

namespace ConsoleAppPadre

{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean seguir = true;
            while (seguir)
            {
                //entrada datos calculadora
                String ope;
                Console.WriteLine("Escriba que operacion quiere realizar:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                ope = Console.ReadLine();

                //comprobar operacion
                while (!(ope.Equals("1") | ope.Equals("2") | ope.Equals("3") | ope.Equals("4")))
                {
                    Console.WriteLine("Escriba que operacion quiere realizar:");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicacion");
                    Console.WriteLine("4. Division");

                    ope = Console.ReadLine();
                }

                switch (ope)
                {
                    case "1":
                        ope = "s";
                        break;
                    case "2":
                        ope = "r";
                        break;
                    case "3":
                        ope = "m";
                        break;
                    case "4":
                        ope = "d";

                        break;
                    default:
                        break;
                }

                Console.WriteLine("Escriba 1º numero");
                String num1s = Console.ReadLine();
                Double num1d;
                while (!Double.TryParse(num1s, out num1d))
                {
                    //comprobar 1º numero
                    Console.WriteLine("Introduce un numero valido");
                    Console.WriteLine("Escriba 1º numero");
                    num1s = Console.ReadLine();

                }
                num1d = Double.Parse(num1s);

                Console.WriteLine("Escriba 2º numero");
                String num2s = Console.ReadLine();
                Double num2d;
                while (!Double.TryParse(num2s, out num2d))
                {
                    //comprobar 2º numero
                    Console.WriteLine("Introduce un numero valido");
                    Console.WriteLine("Escriba 2º numero");
                    num2s = Console.ReadLine();

                }
                num2d = Double.Parse(num2s);

                Double calculo;

                calculo = ConsoleAppHijo.Program.Operaciones(num1d, num2d, ope);

                Console.WriteLine("¿Hacer otra operacion? 's' 'n'");
                String seg = Console.ReadLine();
                if (seg.Equals("n") | seg.Equals("N"))
                {
                    seguir = false;
                }
            }

        }
    }
}