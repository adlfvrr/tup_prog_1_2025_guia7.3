namespace ej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, contop0 = 0, contop1 = 0, contop2 = 0, contop = 0;
            double porop0 = 0, porop1 = 0, porop2 = 0;
            bool salida = true;
            string salir;
            do
            {
                Console.WriteLine("Ingrese opinion: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch(op)
                {
                    case 0:
                        contop0++; contop++; break;
                    case 1:
                        contop1++; contop++; break;
                    case 2:
                        contop2++; contop++; break;
                    default:
                        Console.WriteLine("Opinión inválida"); break;
                }
                Console.WriteLine("Desea continuar? (Ingrese 'salir' en caso de no): ");
                salir = Console.ReadLine();
                if (salir == "salir")
                {
                    salida = false;
                }
            }
            while (salida);
            if (contop > 0)
            {
                porop0 = 1.0 * ((contop0 / (double)contop)*100);
                porop1 = 1.0 * ((contop1 / (double)contop)*100);
                porop2 = 1.0 * ((contop2 / (double)contop)*100);
                Console.WriteLine($"Los porcentajes de la encuesta son: \n Positivo: {porop0:f2}%\n Negativo: {porop1:f2}%\n Indeciso: {porop2:f2}%");
            }
            else
            {
                Console.WriteLine("No hubo encuestados");
            }
        }
    }
}
