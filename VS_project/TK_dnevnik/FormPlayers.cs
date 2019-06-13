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
    public partial class FormPlayers : Form
    {
        BindingSource bsIgraci = new BindingSource();
        public FormPlayers()
        {
            InitializeComponent();
        }

        private void FormPlayers_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.playersOpen = false;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
            {
                FormMain.myConnection.Open();
                try
                {
                    string mySqlString = "INSERT INTO Igraci (Ime, Prezime, Visina, Desnjak, DvorucniBekend, GlavnoOruzje, ClanOd) VALUES(@Ime, @Prezime, @Visina, @Desnjak, @Bekend, @Oruzje, @ClanOd)";
                    //@Ime, @Prezime, @Visina, @Desnjak, @Bekend, @Oruzje, @ClanOd
                    SqlCommand myCom = new SqlCommand(mySqlString, FormMain.myConnection);

                    myCom.Parameters.AddWithValue("@Ime", tbIme.Text);
                    myCom.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
                    myCom.Parameters.AddWithValue("@Visina", tbVisina.Text);
                    if(cbDesnjakLjevak.Text == "Dešnjak")
                    {
                        myCom.Parameters.AddWithValue("@Desnjak", 1);
                    }
                    else
                    {
                        myCom.Parameters.AddWithValue("@Desnjak", 0);
                    }
                    if (cbDvorucniJednorucni.Text == "Dvoručni")
                    {
                        myCom.Parameters.AddWithValue("@Bekend", 1);
                    }
                    else
                    {
                        myCom.Parameters.AddWithValue("@Bekend", 0);
                    }
                    myCom.Parameters.AddWithValue("@Oruzje", tbGlavnoOruzje.Text);
                    myCom.Parameters.AddWithValue("@ClanOd", tbClanOd.Text);

                    myCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                FormMain.myConnection.Close();
            }
            BindDataPlayers();
        }

        private void FormPlayers_Load(object sender, EventArgs e)
        {
            BindDataPlayers();
            //dataGridViewPlayers.Rows[0].Cells[0].Selected = true;
            //if (dataGridViewPlayers.Rows[0].Cells[0].Value != null)
            //{
            //    labelID.Text = dataGridViewPlayers.Rows[0].Cells[0].Value.ToString();
            //}
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
            dataGridViewPlayers.DataSource = bsIgraci;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izmijeniti podatke igrača?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
                {
                    FormMain.myConnection.Open();
                    try
                    {
                        string mySqlString = "UPDATE Igraci SET Ime = @Ime, Prezime = @Prezime, Visina = @Visina, Desnjak = @Desnjak, DvorucniBekend = @Bekend, GlavnoOruzje = @Oruzje, ClanOd = @ClanOd WHERE igracID = @iID";
                        //@Ime, @Prezime, @Visina, @Desnjak, @Bekend, @Oruzje, @ClanOd
                        SqlCommand myCom = new SqlCommand(mySqlString, FormMain.myConnection);

                        myCom.Parameters.AddWithValue("@Ime", tbIme.Text);
                        myCom.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
                        myCom.Parameters.AddWithValue("@Visina", tbVisina.Text);
                        if (cbDesnjakLjevak.Text == "Dešnjak")
                        {
                            myCom.Parameters.AddWithValue("@Desnjak", 1);
                        }
                        else
                        {
                            myCom.Parameters.AddWithValue("@Desnjak", 0);
                        }
                        if (cbDvorucniJednorucni.Text == "Dvoručni")
                        {
                            myCom.Parameters.AddWithValue("@Bekend", 1);
                        }
                        else
                        {
                            myCom.Parameters.AddWithValue("@Bekend", 0);
                        }
                        myCom.Parameters.AddWithValue("@Oruzje", tbGlavnoOruzje.Text);
                        myCom.Parameters.AddWithValue("@ClanOd", tbClanOd.Text);
                        myCom.Parameters.AddWithValue("@iID", labelID.Text);

                        myCom.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                    FormMain.myConnection.Close();
                }
                BindDataPlayers();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati igrača?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
                {
                    FormMain.myConnection.Open();
                    try
                    {
                        string mySqlString = "DELETE FROM Igraci WHERE igracID = @iID";
                        SqlCommand myCom = new SqlCommand(mySqlString, FormMain.myConnection);

                        myCom.Parameters.AddWithValue("@iID", labelID.Text);

                        myCom.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                    FormMain.myConnection.Close();
                }
                BindDataPlayers();
            }
        }

        private void dataGridViewPlayers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int b = (int)dataGridViewPlayers.Rows[dataGridViewPlayers.SelectedCells[0].RowIndex].Cells[0].Value;
            labelID.Text = b.ToString();
        }

        private void dataGridViewPlayers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPlayers.Focused && dataGridViewPlayers.SelectedCells.Count == 1)
            {
                int b = (int)dataGridViewPlayers.Rows[dataGridViewPlayers.SelectedCells[0].RowIndex].Cells[0].Value;
                labelID.Text = b.ToString();
            }
        }

        private void labelID_TextChanged(object sender, EventArgs e)
        {
            if(dataGridViewPlayers.Focused && dataGridViewPlayers.SelectedCells.Count == 1 && dataGridViewPlayers.RowCount > dataGridViewPlayers.SelectedCells[0].RowIndex)
            {
                int odabranRow = (int)dataGridViewPlayers.SelectedCells[0].RowIndex;
                tbIme.Text = dataGridViewPlayers.Rows[odabranRow].Cells[1].Value.ToString();
                tbPrezime.Text = dataGridViewPlayers.Rows[odabranRow].Cells[2].Value.ToString();
                tbVisina.Text = dataGridViewPlayers.Rows[odabranRow].Cells[3].Value.ToString();
                if ((bool)dataGridViewPlayers.Rows[odabranRow].Cells[4].Value == true)
                {
                    cbDesnjakLjevak.Text = "Dešnjak";
                }
                else
                {
                    cbDesnjakLjevak.Text = "Ljevak";
                }
                if ((bool)dataGridViewPlayers.Rows[odabranRow].Cells[5].Value == true)
                {
                    cbDvorucniJednorucni.Text = "Dvoručni";
                }
                else
                {
                    cbDvorucniJednorucni.Text = "Jednoručni";
                }
                tbGlavnoOruzje.Text = dataGridViewPlayers.Rows[odabranRow].Cells[6].Value.ToString();
                tbClanOd.Text = dataGridViewPlayers.Rows[odabranRow].Cells[7].Value.ToString();
            }
        }
    }
}
