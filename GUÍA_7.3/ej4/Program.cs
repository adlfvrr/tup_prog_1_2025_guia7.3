namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, mayor = 0, menor = 0;
            for (int cont = 0; cont < 30; cont++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (mayor == 0 & menor == 0)
                {
                    mayor = n;
                    menor = n;
                }
                else
                {
                    if (n > mayor)
                    {
                        mayor = n;
                    }
                    else
                    {
                        if (n < menor)
                        {
                            menor = n;
                        }
                    }
                }
                Console.WriteLine($"El mayor numero ingresado es {mayor} y el menor {menor}.");
            }
        }
    }
}