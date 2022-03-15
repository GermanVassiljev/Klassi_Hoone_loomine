using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class Hoone
    {
        public int Pindala { get; set; }
        public Uks uks;
        public EraMaja Suurus;  
        public Hoone(int pindala)
        {
            Pindala = pindala;
        }
        public int pindala
        {
            set {}
            get { return pindala; }
        }
        public Uks GetUks()
        {
            return uks;
        }
        public void NaitaInfo()
        {
            Console.WriteLine("Hoone info:");
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, ja see on {Suurus}");
            Console.WriteLine("Ukse info:");
        }
    }

}
