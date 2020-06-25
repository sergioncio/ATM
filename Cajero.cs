using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    class Cajero
    {
        private double saldo;

        public Cajero(double saldo) 
        {
            this.saldo = saldo;
        }

        public double Ingresar(double dinero)
        {
           Console.WriteLine("Dinero ingresado con éxito.");
           return this.saldo += dinero;
        }

        public double Retirar(double dinero)
        {

            if (dinero > saldo)
            {
                Console.WriteLine("El saldo disponible es inferior al dinero que quiere retirar, por lo tanto se le cobrará una comisión de 5 euros");
                Console.WriteLine("¿Desea continuar con la operación? = 1-Sí 2-No");
                int decision = Convert.ToInt16(Console.ReadLine());
                if (decision == 1)
                {
                    saldo -= 5;
                    Console.WriteLine("Dinero retirado con éxito.");
                    return this.saldo -= dinero;
                }
                else if (decision == 2)
                {
                    return saldo;
                }
                else
                {
                    Console.WriteLine("Operación no disponible");
                    return saldo;
                }
            }
            else 
            {
                Console.WriteLine("Dinero retirado con éxito.");
                return this.saldo -= dinero;
            }
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
        }
    }
}
