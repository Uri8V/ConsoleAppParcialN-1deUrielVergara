using System;

namespace ConsoleAppParcialN_1deUrielVergara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio1deUrielVergara";

            float ladoA;
            float ladoB;
            float ladoC;
            float p;
            float Perimetro;
            double Area;

            try
            {
                Console.Write("Ingrese los datos del primer lado ");
                ladoA = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los datos del segundo lado ");
                ladoB = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los datos del tercer lado ");
                ladoC = int.Parse(Console.ReadLine());


                if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
                {
                    Console.WriteLine("Los datos ingresados no permiten realizar la operación (X_X) ");
                }
                else
                {
                    if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
                    {
                        Console.WriteLine("Los datos conforman un triángulo ");
                        Perimetro = ladoA + ladoB + ladoC;
                        Console.WriteLine($"El perimetro del Triángulo es {Perimetro}");
                        p = (ladoA + ladoB + ladoC) / 2;
                        Console.WriteLine($"El semiperimetro del Triángulo es {p}");
                        Area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
                        Console.WriteLine($"El Area del Triángulo es {Area}");
                        if (Math.Pow(ladoA, 2) > Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
                        {
                            Console.WriteLine("Los lados conforman un Triángulo Obtusángulo");
                        }
                        else
                        {
                            if (Math.Pow(ladoA, 2) < Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
                            {
                                Console.WriteLine("Los lados conforman un Triángulo Acutángulo ");
                            }
                            else
                            {
                                Console.WriteLine("Los lados conforman un Triángulo Rectángulo");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los datos no conforman un Triángulo ");
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Los datos ingresados son erroneos ");
            }

            Console.ReadLine();
        }
    }
}
