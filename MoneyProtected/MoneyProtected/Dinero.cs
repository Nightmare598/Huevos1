using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyProtected
{
    class Dinero
    {
       public int Identificar(double x)
        {
            int bil=0;
            //En cada if entra los valores de los direntes sensores
            if (x == 1)
            {
                bil = 10;

            }
            else if (x==0)
            {
                bil = 50;
            }
            else
            {
                bil = 30;
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
