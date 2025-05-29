namespace ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,cont = 0, mayor= 0, menor= 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 0 & n <= 100)
                {
                    if (mayor == 0 & menor == 0)
                    {
                        mayor = n;
                        menor = n;
                        cont++;
                    }
                    else
                    {
                        if (n > mayor)
                        {
                            mayor = n;
                            cont++;
                        }
                        else
                        {
                            if (n < menor)
                            {
                                menor = n;
                                cont++;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fuera de rango");
                }
                Console.WriteLine("Desea continuar? (-1 en caso de no): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n!= -1);
            if (cont > 0)
            {
                Console.WriteLine($"El mayor de los numeros ingresados es {mayor} y el menor {menor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números");
            }
        }
    }
}
