namespace ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ac = 0,n,contnum = 0; 
            double prom = 0;
            for (int cont = 0; cont <20; cont++ )
            {
                Console.WriteLine("Ingrese un número: ");
                n = Convert.ToInt32(Console.ReadLine());
                ac += n;
                contnum++;
            }
            prom = ac / contnum;
            Console.WriteLine($"El promedio de los números es de {prom:f2}");
        }
    }
}
