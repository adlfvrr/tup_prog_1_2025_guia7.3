namespace ej2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cont = 0, ac = 0;
            double prom = 0;
            do
            {
                Console.WriteLine("Ingrese un número: ");
                n = Convert.ToInt32(Console.ReadLine());
                ac += n;
                cont++;
                Console.WriteLine("Desea continuar? (-1 en caso de no): ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n!=1);
            if (cont > 0)
            {
                prom = ac/ cont;
                Console.WriteLine($"El promedio de los numeros ingresados es de: {prom:f2}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por 0");
            }
        }
    }
}
