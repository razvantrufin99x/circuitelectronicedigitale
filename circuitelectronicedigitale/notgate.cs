using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuitelectronicedigitale
{
    public class notgate : gate
    {
        public pin pinIn = new pin();
        public pin pinOut = new pin();
        public void negatie()
        {
            if (pinIn.valoare == 0)
            {
                pinOut.valoare = 1;
            }
            if (pinIn.valoare == 1)
            {
                pinOut.valoare = 0;
            }

        }
    }
}
