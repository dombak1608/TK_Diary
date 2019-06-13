using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TK_dnevnik
{
    public partial class FormZdrijebDodavanje : Form
    {

        public FormZdrijebDodavanje()
        {
            InitializeComponent();
        }

        private void FormZdrijebDodavanje_Load(object sender, EventArgs e)
        {
            if (FormZdrijeb.izmjena == true)
            {
                button1.Text = "Izmjeni turnir";
                tbNaziv.Text = FormZdrijeb.nazivTurnira;
                tbBrBodova.Text = FormZdrijeb.brBodova.ToString();
                tbBrIgraca.Text = FormZdrijeb.brIgraca.ToString();
                dateTimePicker1.Value = FormZdrijeb.datumTurnira;
                if(FormZdrijeb.singl)
                {
                    rbSingl.Checked = true;
                }
                else
                {
                    rbParovi.Checked = true;
                }
                if(FormZdrijeb.grupe)
                {
                    rbGrupeDa.Checked = true;
                }
                else
                {
                    rbGrupeNe.Checked = true;
                }
            }
            else
            {
                button1.Text = "Dodaj turnir";

                tbNaziv.Text = "";
                tbBrBodova.Text = "";
                tbBrIgraca.Text = "";
                rbSingl.Checked = true;
                rbGrupeNe.Checked = true;
            }
        }

        private void FormZdrijebDodavanje_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!FormMain.zdrijebOpen)
            {
                FormMain.dodavanjeOpen = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FormMain.zdrijebOpen)
                {
                    if(FormZdrijeb.izmjena)
                    {
                        int brIgr;
                        int.TryParse(tbBrIgraca.Text, out brIgr);
                        if(brIgr < FormZdrijeb.brIgraca)
                        {
                            DialogResult dRes = MessageBox.Show("Smanjili ste broj igrača u turniru, postoji mogućnost da će se određeni podaci izgubiti." +
                                "\nŽelite li nastaviti?", "Upozorenje", MessageBoxButtons.YesNo);
                            if(dRes==DialogResult.Yes)
                            {
                                otvoriZdrijeb();
                            }
                        }
                        else
                        {
                            otvoriZdrijeb();
                        }
                    }
                    else
                    {
                        otvoriZdrijeb();
                    }
                }
                else
                {
                    throw new Exception("Prozor za dodavanje turnira je već otvoren!");
                    //MessageBox.Show("Prozor za dodavanje turnira je već otvoren", "Upozorenje", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void otvoriZdrijeb()
        {
            FormZdrijeb.nazivTurnira = tbNaziv.Text;
            int.TryParse(tbBrBodova.Text, out FormZdrijeb.brBodova);
            int.TryParse(tbBrIgraca.Text, out FormZdrijeb.brIgraca);
            if (FormZdrijeb.brIgraca < 1 || FormZdrijeb.brBodova < 1)
            {
                throw new Exception("Neispravan unos!");
            }
            if (FormZdrijeb.brIgraca > 32)
            {
                throw new Exception("Nije moguće dodati više od 32 igrača u turnir.");
            }
            if (rbSingl.Checked)
            {
                FormZdrijeb.singl = true;
            }
            else
            {
                FormZdrijeb.singl = false;
            }
            if (rbGrupeDa.Checked)
            {
                FormZdrijeb.grupe = true;
            }
            else
            {
                FormZdrijeb.grupe = false;
            }
            FormZdrijeb.datumTurnira = dateTimePicker1.Value;
            FormMain.zdrijebOpen = true;
            FormZdrijeb zdrijebF = new FormZdrijeb();
            zdrijebF.Show();

            this.Close();
        }

        private void rbParovi_CheckedChanged(object sender, EventArgs e)
        {
            if(rbParovi.Checked)
            {
                label3.Text = "Broj parova:";
            }
            else
            {
                label3.Text = "Broj igrača:";
            }
        }
    }
}
