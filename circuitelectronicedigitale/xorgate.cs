using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitelectronicedigitale
{
    public class xorgate : gate
    {
        public pin pinIn1 = new pin();
        public pin pinIn2 = new pin();

        public pin pinOut = new pin();

        public void xordisjunctie()
        {

            if (pinIn1.valoare == 0 && pinIn2.valoare == 0)
            {
                pinOut.valoare = 0;
            }
            else if (pinIn1.valoare == 0 && pinIn2.valoare == 1)
            {
                pinOut.valoare = 1;
            }
            else if (pinIn1.valoare == 1 && pinIn2.valoare == 0)
            {
                pinOut.valoare = 1;
            }
            else if (pinIn1.valoare == 1 && pinIn2.valoare == 1)
            {
                pinOut.valoare = 0;
            }

        }
    }
}
