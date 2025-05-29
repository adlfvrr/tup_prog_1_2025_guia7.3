namespace ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int venta, cantventas = 0, mayormonto = 0, rectotal = 0, cantrubro1 = 0, cantrubro2 = 0, cantrubro3 = 0, cantrubro5 = 0, montorubro1 = 0, montorubro2 = 0, montorubro3 = 0, montorubro5 = 0, mayorventa = 0;
            bool seguir = true;
            double porrubro1 = 0, porrubro2 = 0, porrubro3 = 0, porrubro5 = 0;
            while(seguir)
            {
                Console.WriteLine("Ingrese número de venta: ");
                venta = Convert.ToInt32(Console.ReadLine());
                switch (venta)
                {
                    case 1:cantrubro1++;montorubro1 += 22000;rectotal += 22000; break;
                    case 2:cantrubro3 += 2; montorubro3 += 23333; rectotal += 23333; break;
                    case 3: cantrubro5 += 5; montorubro5 += 78555; rectotal += 78555; break;
                    case 4: cantrubro3 += 2; montorubro3 += 23434; rectotal += 23434; break;
                    case 5: cantrubro2 += 4; montorubro2 += 23434; rectotal += 23434; break;
                    default: Console.WriteLine("Venta finalizada"); seguir = false; break;
                }
                cantventas++;
                if (montorubro1 > mayormonto)
                {
                    mayormonto = montorubro1;
                    mayorventa = 1;
                }
                else
                {
                    if (montorubro2 > mayormonto)
                    {
                        mayormonto = montorubro2;
                        mayorventa = 2;
                    }
                    else
                    {
                        if (montorubro3 > mayormonto)
                        {
                            mayormonto = montorubro3;
                            mayorventa = 3;
                        }
                        else
                        {
                            if (montorubro5 > mayormonto)
                            {
                                mayormonto = montorubro5;
                                mayorventa = 5;
                            }
                        }
                    }
                }
            }
            porrubro1 = 1.0 * ((cantrubro1 / (double)cantventas) * 100);
            porrubro2 = 1.0 * ((cantrubro2 / (double)cantventas) * 100);
            porrubro3 = 1.0 * ((cantrubro3 / (double)cantventas) * 100);
            porrubro5 = 1.0 * ((cantrubro5 / (double)cantventas) * 100);
            Console.WriteLine($"Los porcentajes de venta de cada rubro son: \n Rubro 1: {porrubro1:f2}%\n Rubro 2: {porrubro2:f2}%\n Rubro3: {porrubro3:f2}%\n Rubro 5: {porrubro5:f2}%");
            Console.WriteLine($"La recaudación total es de {rectotal}$\n El numero de venta con mayor monto total es el {mayorventa}, con un total de ${mayormonto}");
        }
    }
}
