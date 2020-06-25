using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            Boolean estado = true;
            Cajero c = new Cajero(saldo);

            while (estado) { 
               Console.WriteLine("Seleccione la operación a realizar: 1-Ingresar dinero, 2-Retirar dinero, 3-Consultar saldo, 4-Finalizar transacciones");
               int op = Convert.ToInt16(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Introduzca la cantidad de dinero que quiere ingresar: ");
                    double dinero = Convert.ToDouble(Console.ReadLine());
                    c.Ingresar(dinero);  
                }
                else if (op == 2)
                {
                    Console.WriteLine("Introduzca la cantidad de dinero que quiere retirar: ");
                    double dinero = Convert.ToDouble(Console.ReadLine());
                    c.Retirar(dinero);
                    Console.WriteLine();
                }
                else if (op == 3)
                {
                    Console.WriteLine("El saldo disponible en su cuenta es de: {0} euros \n", c.Saldo);
                }
                else if (op == 4)
                {
                    estado = false;
                    c = null;
                    GC.Collect();
                }
                else
                {
                    Console.WriteLine("La operación seleccionada no es válida. \n");
                }
            }
            string a = Console.ReadLine();
        }
    }
}
