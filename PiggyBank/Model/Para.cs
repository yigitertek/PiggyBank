using PiggyBank.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Model
{
    public class Para
    {
        public ParaAdi ParaAdi { get; set; }
        public decimal Degeri { get; set; }

        public int ParaBoyutu { get; set; }

        public double FazladanKaplananHacimOranı { get; set; } = 1;

        public double KaplananHacim
        {
            get
            {
                return GercekHacim * FazladanKaplananHacimOranı;
            }
        }

        public virtual double GercekHacim
        {
            get
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return ParaAdi + " ";
        }
    }
}
