using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Model
{
    public class MadeniPara : Para
    {
        public static readonly double PI = 3.14;
        public double Cap { get; set; }

        public double Yukseklik { get; set; }

        public override double GercekHacim
        {
            get
            {
                return PI * (Cap / 2) * (Cap / 2) * Yukseklik;
            }
        }
    }
}
