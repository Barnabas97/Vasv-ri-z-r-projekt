using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendégGridview
{
    public partial class Login : Form
    {
       

        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void buttonBejelentkezes_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!textBox1.Firstletteruppercase())
            {
                return;
            }


            if (!textBox2.Firstletteruppercase())
            {
                return;
            }





            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                errorProvider1.SetError(buttonBejelentkezes,"Hibás felhasználónév vagy jelszó!");
            }
            
        }

        
    }
}
