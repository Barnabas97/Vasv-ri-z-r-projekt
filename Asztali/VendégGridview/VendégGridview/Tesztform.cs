using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToMysqlDatabase;

namespace VendégGridview
{
    public partial class Tesztform : Form
    {
        private MySQLDatabaseInterface mdi;

        private DataTable csillagokDT;

        private bool lettModositva = false;

        public Tesztform()
        {
            InitializeComponent();
            beallitVezerloketIndulaskor();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (!lettModositva)
            {
                if (MessageBox.Show(
                "Nem mentett adatok vannak! Valóban ki akar lépni?",
                "Kilépés",
                MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mdi.close();
                    this.Close();
                }
            }
            else
            {
                mdi.close();
                Application.Exit();
            }
        }

        

        private void dataGridViewCsillagasz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void beallitVezerloketIndulaskor()
        {
            buttonNew.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonSave.Visible = false;
        }

        private void dataGridViewCsillagasz_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feltoltVezerlotAdatbazisbolMindenAdattal()
        {
            Adatbazis a = new Adatbazis();
            mdi = a.kapcsolodas();
            mdi.open();
            csillagokDT = mdi.getToDataTable("SELECT kerdesszam, akerdes FROM kerdesek");
            dataGridViewCsillagasz.DataSource = csillagokDT;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
           
        }

        private void beallitVezerloketNemSzerkeszthetoAdateleressel()
        {
            //gombok beállítása
            buttonNew.Visible = true;
            buttonNew.Enabled = true;
            buttonEdit.Visible = true;
            buttonEdit.Enabled = true;
            buttonDelete.Visible = true;
            buttonDelete.Enabled = true;

            buttonSave.Visible = false;
            buttonCancel.Visible = false;

            //dataGridView beállítása
            dataGridViewCsillagasz.ReadOnly = true;
            dataGridViewCsillagasz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCsillagasz.AllowUserToDeleteRows = false;
        }

        private void beallitVezerloketDataGridViewSzerkesztoUzemmodba()
        {
            //gombok beállítása
            buttonNew.Visible = false;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonSave.Visible = true;


            //dataGridView beállítása
            dataGridViewCsillagasz.ReadOnly = false;
            dataGridViewCsillagasz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCsillagasz.AllowUserToDeleteRows = false;

            //új gombot kell felvenni, mert a szerkesztés akár megszakítható is
            buttonCancel.Visible = true;
            lettModositva = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            beallitVezerloketDataGridViewSzerkesztoUzemmodba();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatfelvitelkor();
            int sor = dataGridViewCsillagasz.Rows.Count - 1;
            dataGridViewCsillagasz.Rows[sor].Cells[1].Selected = true;
            dataGridViewCsillagasz.Rows[sor].Cells[1].Value = "Írja ide az új adatot";
            dataGridViewCsillagasz.ReadOnly = false;
            for (int i = 0; i < sor; i = i + 1)
                dataGridViewCsillagasz.Rows[i].ReadOnly = true;
            dataGridViewCsillagasz.FirstDisplayedScrollingRowIndex = sor;
            dataGridViewCsillagasz.Columns[0].ReadOnly = false;
        }

        private void beallitVezerloketUjAdatfelvitelkor()
        {
            buttonNew.Visible = false;
            buttonSave.Enabled = true;
            buttonSave.Visible = true;
            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled = true;

            dataGridViewCsillagasz.AllowUserToAddRows = true;
            dataGridViewCsillagasz.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCsillagasz_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tesztform t = new Tesztform();
            t.Show();
            this.Hide();
        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();
            DataGridViewColumn column = dataGridViewCsillagasz.Columns[1];
            column.Width = 400;
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            beallitVezerloketUjAdatfelvitelkor();
            int sor = dataGridViewCsillagasz.Rows.Count - 1;
            dataGridViewCsillagasz.Rows[sor].Cells[1].Selected = true;
            dataGridViewCsillagasz.Rows[sor].Cells[1].Value = "Írja ide az új adatot";
            dataGridViewCsillagasz.ReadOnly = false;
            for (int i = 0; i < sor; i = i + 1)
                dataGridViewCsillagasz.Rows[i].ReadOnly = true;
            dataGridViewCsillagasz.FirstDisplayedScrollingRowIndex = sor;
            dataGridViewCsillagasz.Columns[0].ReadOnly = false;
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            beallitVezerloketDataGridViewSzerkesztoUzemmodba();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                //meghatározzuk a kijelölt sort
                int sor = dataGridViewCsillagasz.SelectedRows[0].Index;
                if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation
                ) == DialogResult.Yes)
                {
                    //töröljük a sort a DataGridView-ból
                    dataGridViewCsillagasz.Rows.RemoveAt(sor);
                    //Lehetővé tesszük a mentést
                    buttonSave.Visible = true;
                    lettModositva = true;
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                "Jelölje ki a törlendő sort!",
                "Törlés",
                MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            if (!lettModositva)
            {
                MessageBox.Show(
                "Nem lett módosítva egy adat sem.",
                "Módosítás",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                mdi.updateChangesInTable(csillagokDT);
                beallitVezerloketNemSzerkeszthetoAdateleressel();
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            feltoltVezerlotAdatbazisbolMindenAdattal();
            beallitVezerloketNemSzerkeszthetoAdateleressel();
        }

        private void dataGridViewCsillagasz_CellValueChanged_2(object sender, DataGridViewCellEventArgs e)
        {
            lettModositva = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 alapform = new Form1();
            alapform.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teszt2 t2 = new Teszt2();
            t2.Show();
            this.Hide();
        }
    }
}
