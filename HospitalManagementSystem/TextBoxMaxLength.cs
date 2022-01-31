using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public class TextBoxMaxLength
    {
        public void BunifuMetro(Bunifu.Framework.UI.BunifuMetroTextbox metroTextbox, int deger)
        {
            foreach (var ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = deger;
                }
            }
        }
    }
}
