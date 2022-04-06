using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public KorteriteMaja korteritemaja;
        public Hoone(int pindala = 50)
        {
            Pindala = pindala;
        }
        public Uks GetUks()
        {
            return uks;
        }
        public abstract void NaitaInfo();
    }

}
