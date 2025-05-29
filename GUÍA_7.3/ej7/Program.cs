using System.Numerics;
using System.Runtime.ExceptionServices;

namespace ej7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, acprom, gmayorprom = 0, gmenorprom = 0, contingresopara;
            double promg1 = 0, promg2 = 0, promg3 = 0, promg4 = 0, mayorprom = 0, menorprom = 0, prom;
            for (int contgrupo = 1; contgrupo < 5; contgrupo++)
            {
                acprom = 0;
                prom = 0;
                contingresopara = 1;
                Console.WriteLine($"Ingrese primer valor para el grupo {contgrupo}: ");
                for (int contingreso = 1; contingreso < 7; contingreso++)
                {
                    Console.Write("Ingrese valor: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    acprom += n;
                    contingresopara++;
                }
                prom = 1.0 * (acprom / (double)contingresopara);
                if (promg1 == 0)
                {
                    promg1 = prom;
                }
                else
                {
                    if (promg2 == 0)
                    {
                        promg2 = prom;
                    }
                    else
                    {
                        if (promg3 == 0)
                        {
                            promg3 = prom;
                        }
                        else
                        {
                            promg4 = prom;
                        }
                    }
                }
                if (mayorprom == 0)
                {
                    mayorprom = promg1;
                }
                else {
                    if (promg1 > mayorprom)
                    {
                        mayorprom = promg1;
                        gmayorprom = 1;
                    }
                    else if (promg2 > mayorprom)
                    {
                        mayorprom = promg2;
                        gmayorprom = 2;
                    }
                    else if (promg3 > mayorprom)
                    {
                        mayorprom = promg3;
                        gmayorprom = 3;
                    }
                    else if (promg4 > mayorprom)
                    {
                        mayorprom = promg4;
                        gmayorprom = 4;
                    }
                }
                if (menorprom == 0)
                {
                    menorprom = promg1;
                }
                else
                {
                    if (promg1 < menorprom)
                    {
                        menorprom = promg1;
                        gmenorprom = 1;
                    }
                    else if (promg2 < menorprom)
                    {
                        menorprom = promg2;
                        gmenorprom = 2;
                    }
                    else if (promg3 < menorprom)
                    {
                        menorprom= promg3;
                        gmenorprom = 3;
                    }
                    else if (promg4 < menorprom)
                    {
                        menorprom = promg3;
                        gmenorprom = 4;
                    }
                }
            }
            Console.WriteLine($"Los promedios son: \n Grupo 1: {promg1:f2}\n Grupo 2: {promg2:f2} \n Grupo 3: {promg3:f2} \n Grupo 4: {promg4:f2}");
            Console.WriteLine($"El mayor promedio es de {mayorprom:f2}, perteneciente al grupo {gmayorprom} \nEl menor promedio es de {menorprom:f2}, perteneciente al grupo {gmenorprom}");
        }
    }
}
