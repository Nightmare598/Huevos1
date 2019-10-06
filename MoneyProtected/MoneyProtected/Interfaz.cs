using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyProtected
{
    class Interfaz:Caja
    {
        public Contabilidad Total { get; set; }
        public bool Confirmar()
        {
            bool b;
            
            if (Saldo == Total.TotalContabilidad)
            {
                b = true;
            }
            else b = false;

            return b;
        }
        /*
        public void Transaccion(int Total_Contabilidad, int Total_Cliente, int Billete)
        {

            Entrada(Billete, ref Total_Contabilidad);
            x= Cambio(total, ref dinliente);
            Salida(Billete, ref Total_Contabilidad);

        }*/
    }
}
