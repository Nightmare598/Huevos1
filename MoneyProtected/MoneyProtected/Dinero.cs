using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyProtected
{
    class Dinero
    {
       public int Identificar(int x)
        {
            int bil=0;
            //En cada if entra los valores de los direntes sensores
            if (x == 10)
            {
                bil = 10;
            }
            /*
            if ()
            {
                bil = 20;
            }
            if (false)
            {
                bil = 50;
            }
            if (false)
            {
                bil = 100;
            }
            if (false)
            {
                bil = 200;
            }*/
            return bil;

        }
    }
}
