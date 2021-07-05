using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendégGridview
{
    public static class Validator
    {
        static public bool Firstletteruppercase(this TextBox t1) {

            if (char.IsUpper(t1.Text[0]))
            {
                return true;
            }
            else
                return false;

        }


        static public bool Firstletteruppercase2(this TextBox t2)
        {

            if (char.IsUpper(t2.Text[0]))
            {
                return true;
            }
            else
                return false;

        }



    }
}
