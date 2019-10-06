using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyProtected
{
    public class Contabilidad
    {
        public int TotalContabilidad { get; set; }
        public int TotalCliente { get; set; }
        public Contabilidad()
        {
            Random rdn = new Random();
            TotalContabilidad = rdn.Next(1, 250)*10;
         }
        public int GenerarTotal()
        {
            Random rdn = new Random();
            TotalCliente = rdn.Next(1, 9)*20;
            return TotalCliente;
        }

    }
}
