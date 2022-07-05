using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Model
{
    public class KagitPara : Para
    {
        private static readonly double KALINLIK = 0.25;

        public double Boy { get; set; }

        public double En { get; set; }

        public override double GercekHacim
        {
            get
            {
                return Boy * (En / 4) * (KALINLIK * 4);
            }
        }
    }
}
