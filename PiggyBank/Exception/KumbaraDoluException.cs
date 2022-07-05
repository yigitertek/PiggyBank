using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank.Exception
{
    [Serializable]
    public class KumbaraDoluException : System.Exception
    {
        public KumbaraDoluException() { }

        public KumbaraDoluException(string message) : base(message) { }
    }
}
