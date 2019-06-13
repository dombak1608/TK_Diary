using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace TK_dnevnik
{
    public partial class FormTournaments : Form
    {
        BindingSource bsTurniri = new BindingSource();
        BindingSource bsIgraci = new BindingSource();
        public FormTournaments()
        {
            InitializeComponent();
        }

        private void FormTournaments_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.tournamentsOpen = false;
        }

        private void FormTournaments_Load(object sender, EventArgs e)
        {
            //BindDataPlayers();
            BindDataTournaments();
            //dataGridViewTournaments.Rows[0].Cells[0].Selected = true;
            //if (dataGridViewTournaments.Rows[0].Cells[0].Value != null)
            //{
            //    labelID.Text = dataGridViewTournaments.Rows[0].Cells[0].Value.ToString();
            //}
        }
        private void BindDataTournaments()
        {
            using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
            {
                FormMain.myConnection.Open();
                using (FormMain.myDbDataAdapter = new SqlDataAdapter())
                {
                    DataSet myDataSet = new DataSet();

                    FormMain.myDbDataAdapter.SelectCommand = new SqlCommand("SELECT turnirID AS 'Redni broj', Naziv, Bodovi, BrIgraca AS 'Broj igrača', Datum, Singl, Grupe FROM Turniri", FormMain.myConnection);
                    FormMain.myDbDataAdapter.Fill(myDataSet, "Turniri");

                    bsTurniri.DataSource = myDataSet;
                    bsTurniri.DataMember = "Turniri";

                    FormMain.myConnection.Close();
                }
            }
            dataGridViewTournaments.DataSource = bsTurniri;
        }
        private void BindDataPlayers()
        {
            using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
            {
                FormMain.myConnection.Open();
                using (FormMain.myDbDataAdapter = new SqlDataAdapter())
                {
                    DataSet myDataSet = new DataSet();

                    FormMain.myDbDataAdapter.SelectCommand = new SqlCommand("SELECT igracID AS 'Redni broj', Ime, Prezime, Visina, Desnjak AS 'Dešnjak', DvorucniBekend AS 'Dvoručni bekend', GlavnoOruzje AS 'Glavno oružje', ClanOd AS 'Član od' FROM Igraci", FormMain.myConnection);
                    FormMain.myDbDataAdapter.Fill(myDataSet, "Igraci");

                    bsIgraci.DataSource = myDataSet;
                    bsIgraci.DataMember = "Igraci";

                    FormMain.myConnection.Close();
                }
            }
            dataGridViewTournaments.DataSource = bsIgraci;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (!FormMain.dodavanjeOpen)
            {
                FormMain.dodavanjeOpen = true;
                FormZdrijeb.izmjena = false;
                FormZdrijebDodavanje dodavanjeF = new FormZdrijebDodavanje();
                dodavanjeF.Show();
            }
            else
            {
                MessageBox.Show("Prozor  je već otvoren", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!FormMain.dodavanjeOpen)
            {
                FormZdrijeb.izmjena = true;
                FormZdrijeb.nazivTurnira = dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                int.TryParse(dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[2].Value.ToString(), out FormZdrijeb.brBodova);
                int.TryParse(dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[3].Value.ToString(), out FormZdrijeb.brIgraca);
                DateTime.TryParse(dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[4].Value.ToString(), out FormZdrijeb.datumTurnira);
                Boolean.TryParse(dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[5].Value.ToString(), out FormZdrijeb.singl);
                Boolean.TryParse(dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[6].Value.ToString(), out FormZdrijeb.grupe);

                //FormZdrijeb.izmjena = true;
                //FormZdrijeb.nazivTurnira = "neki";
                //FormZdrijeb.brBodova = 250;
                //FormZdrijeb.brIgraca = 16;
                //FormZdrijeb.singl = true;
                //FormZdrijeb.grupe = false;

                FormMain.dodavanjeOpen = true;
                FormZdrijebDodavanje dodavanjeF = new FormZdrijebDodavanje();
                dodavanjeF.Show();
            }
            else
            {
                MessageBox.Show("Prozor  je već otvoren", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete iz baze
        }

        private void dataGridViewTournaments_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int b = (int)dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[0].Value;
            labelID.Text = b.ToString();
        }

        private void dataGridViewTournaments_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewTournaments.Focused && dataGridViewTournaments.SelectedCells.Count==1)
            {
                int b = (int)dataGridViewTournaments.Rows[dataGridViewTournaments.SelectedCells[0].RowIndex].Cells[0].Value;
                labelID.Text = b.ToString();
            }
        }
    }
}
