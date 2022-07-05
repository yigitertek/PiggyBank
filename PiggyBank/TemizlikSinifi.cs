using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
   public  static class TemizlikSinifi
    {

        public static void Temizle (Control.ControlCollection kolleksiyon)
        {
            foreach (Control item in kolleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                else if (item is ComboBox)
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.Items.Clear();
                }
                else if (item is GroupBox)
                {
                    GroupBox gb = (GroupBox)item;
                    Temizle(gb.Controls);
                }





            }
        }
    }
}
