using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyProtected
{
    class Caja:Dinero
    {
        public int Numero { get; set; }
        public int Saldo { get; set; }
        // Todos los Billetes en realidad son la plata total que paga el usuario antes de darle cambio
        public void Entrada(int InBillete, ref int saldoActual)
        {
            saldoActual += InBillete;
        }
        public void Salida(int OutBillete, ref int saldoActual)
        {
            saldoActual -= OutBillete;
        }
        public int Cambio(int total_a_pagar, int Billete)
        {
            //recibe plata
            int cambio;
            cambio = Billete - total_a_pagar;
            if (cambio<0)
            {
                //Mensaje de error
            }
            return cambio;
        }

    }
}
