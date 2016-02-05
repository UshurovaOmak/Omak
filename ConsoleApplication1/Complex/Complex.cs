using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public class Complex
    {
        public int a;
        public int b;

        public Complex(int a1, int b1)
        {
            this.a = a1;
            this.b = b1;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            int znamenatel = c1.b * c2.b;
            int chistitel = znamenatel * c1.a + znamenatel * c2.a;
            //
            Complex c = new Complex(chistitel, znamenatel);
            return c;
        }
    }
}
