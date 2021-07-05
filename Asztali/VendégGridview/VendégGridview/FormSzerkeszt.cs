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
    public partial class FormSzerkeszt : Form
    {
        private Csillag cs;

        public FormSzerkeszt(Csillag cs)
        {
            InitializeComponent();
            this.cs = cs;
            textBoxAzonosito.Text = cs.getAzonosito().ToString();
            textBoxNev.Text = cs.getNev();
            textBoxEletkor.Text = cs.getEletkor().ToString();
            textBoxDatum.Text = cs.getDatum().ToString();
            textBoxPontszam.Text = cs.getPontszam().ToString();
        }
    }
}
