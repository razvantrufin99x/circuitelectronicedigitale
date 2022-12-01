using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitelectronicedigitale
{
    public class bitops
    {
        public bits bitA = new bits();
        public bits bitB = new bits();
        public bits rezultbit = new bits();
        public bits carriebit = new bits();

        public void addbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 1;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 1;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }

        public void difbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }
        public void multbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }
        public void divbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }

        public void orbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }

        public void andbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }

        public void xorbits()
        {
            if (bitA.valoare == 1 && bitB.valoare == 1)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 1)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 1 && bitB.valoare == 0)
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 && bitB.valoare == 0)
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
        }


        public void notbits()
        {
            if (bitA.valoare == 1 )
            {
                rezultbit.valoare = 0;
                carriebit.valoare = 0;
            }
            else if (bitA.valoare == 0 )
            {
                rezultbit.valoare = 1;
                carriebit.valoare = 0;
            }
            
        }

    }
}
