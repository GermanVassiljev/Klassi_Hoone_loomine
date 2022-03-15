using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class EraMaja : Hoone
    {
        public string Kodu;
        public Uks Color;
        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Suurus_
        {
            get
            {
                if (pindala <= 20)
                {
                    Kodu = "Väike maja";
                }
                else if (pindala <= 50)
                {
                    Kodu = "Keskmine maja";
                }
                else if (pindala <= 100)
                {
                    Kodu = "Suur maja";
                }
                else
                {
                    Kodu = "Liiga suur maja";
                }
                return Kodu;
            }
        }

    }
}
