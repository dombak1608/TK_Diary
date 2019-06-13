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
    public partial class FormZdrijeb : Form
    {
        public static string nazivTurnira;
        public static int brBodova;
        public static int brIgraca;
        public static DateTime datumTurnira;
        public static Boolean singl;
        public static Boolean grupe;
        public static Boolean izmjena;
        private int bazaKostura;
        private AutoCompleteStringCollection svaPrezIme = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection trenutnaPrezIme = new AutoCompleteStringCollection();

        public FormZdrijeb()
        {
            InitializeComponent();
        }

        private void FormZdrijeb_Load(object sender, EventArgs e)
        {
            lblNaziv.Text = nazivTurnira;
            lblBodovi.Text = brBodova.ToString();
            lblDatum.Text = datumTurnira.ToShortDateString();

            svaPrezIme = getPrezimeIme();

            odrediBazuKostura();
            if(izmjena)
            {
                izmjenaLoad();
            }
            else
            {
                noviLoad();
            }
        }

        private void odrediBazuKostura()
        {
            for(int i=2; i<=32; i*=2)
            {
                if(brIgraca <= i)
                {
                    bazaKostura = i;
                    break;
                }
            }
        }

        private void izmjenaLoad()
        {
            throw new NotImplementedException();
        }

        private void FormZdrijeb_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.zdrijebOpen = false;
            FormMain.dodavanjeOpen = false;
        }

        private void noviLoad()
        {
            if (brIgraca <= 2)
            {
                namjestiTbiCb();
                this.Width = 600;
                this.Height = 200;
            }
            else if (brIgraca <= 4)
            {
                namjestiTbiCb();
                this.Width = 700;
                this.Height = 300;
            }
            else if (brIgraca <= 8)
            {
                namjestiTbiCb();
                this.Width = 950;
                this.Height = 500;
            }
            else if (brIgraca <= 16)
            {
                namjestiTbiCb();
                this.Width = 1175;
                this.Height = 900;
            }
            else if (brIgraca <= 32)
            {
                namjestiTbiCb();
                this.Width = 1400;
                this.Height = 925;
            }
            else
            {
                MessageBox.Show("Nije moguće imati više od 32 igrača", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void namjestiTbiCb()
        {
            for (int i = 1; i < 33; i++)
            {
                TextBox tbPr = (TextBox)this.Controls.Find("textBox" + i.ToString(), true)[0];
                Label lbPr = (Label)this.Controls.Find("lbl" + i.ToString(), true)[0];
                if (i > bazaKostura)
                {
                    tbPr.Hide();
                    lbPr.Hide();
                    //tbPr.Visible = false;
                    //lbPr.Visible = false;
                }
                else
                {
                    tbPr.Show();
                    lbPr.Show();
                    lbPr.Text = i.ToString();
                    //tbPr.Visible = true;
                    //lbPr.Visible = true;
                }
                if (brIgraca < i)
                {
                    tbPr.Text = "-";
                    tbPr.Enabled = false;
                }
                else
                {
                    tbPr.Text = "";
                    tbPr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tbPr.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tbPr.AutoCompleteCustomSource = getPrezimeIme();
                }
            }
            for (int i = 1; i < 6; i++)
            {
                if(bazaKostura <= Math.Pow(2,(i-1)))
                {
                    for(int j = 0; j < 5; j++)
                    {
                        Label lbl1 = (Label)this.Controls.Find("lbKolo" + j, true)[0];
                        Label lbl2 = (Label)this.Controls.Find("lbKolo" + (j + 1), true)[0];
                        lbl1.Text = lbl2.Text;
                    }
                    lbKolo5.Text = "";
                }
                for (int j = 1; j < (Math.Pow(2, 6 - i)); j += 2)
                {
                    TextBox tbPr = (TextBox)this.Controls.Find("tbRez" + i + "_" + j + "_" + (j + 1), true)[0];
                    ComboBox cbPr = (ComboBox)this.Controls.Find("cb" + i + "_" + j + "_" + (j + 1), true)[0];
                    if ((j+1) > (bazaKostura/(Math.Pow(2,(i-1)))))
                    {
                        tbPr.Visible = false;
                        cbPr.Visible = false;
                    }
                    else
                    {
                        tbPr.Visible = true;
                        tbPr.Text = "Rezultat";
                        cbPr.Visible = true;
                    }
                }
            }
        }

        private void FormZdrijeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            //nesto s brIgraca
            stvoriMeceve();

        }

        private void stvoriMeceve()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < (Math.Pow(2, 6 - i)); j += 2)
                {
                    TextBox tbPr = (TextBox)this.Controls.Find("tbRez" + i + "_" + j + "_" + (j + 1), true)[0];
                    ComboBox cbPr = (ComboBox)this.Controls.Find("cb" + i + "_" + j + "_" + (j + 1), true)[0];
                    if ((j + 1) > (bazaKostura / (Math.Pow(2, (i - 1)))))   //oni koji se ne vide
                    {

                    }
                    else //oni koji se vide
                    {
                        if (cbPr.Text != "-")
                        {
                            Match noviMatch = new Match();
                            if(cbPr.Items.Count == 1)   //nema gubitnika i ne mogu se dat bodovi, osim ako je finale
                            {

                            }
                            else if(cbPr.Items.Count == 2)  //ovdje postoji gubitnik
                            {

                            }
                        }
                    }
                }
            }
        }

        public AutoCompleteStringCollection getPrezimeIme()
        {
            AutoCompleteStringCollection res = new AutoCompleteStringCollection();
            string sql = "SELECT Prezime, Ime FROM Igraci";
            using (FormMain.myConnection = new SqlConnection(FormMain.myConnectionString))
            {
                FormMain.myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, FormMain.myConnection))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            if (!r.IsDBNull(0))
                            {
                                res.Add(r.GetString(0) + ", " + r.GetString(1));
                            }
                        }
                    }
                }
            }
            return res;
        }

        private void tbRez1_1_32_TextChanged(object sender, EventArgs e)
        {
            for(int i=1; i<32; i+=2)
            {
                TextBox tbPr1 = (TextBox)this.Controls.Find("textBox" + i, true)[0];
                TextBox tbPr2 = (TextBox)this.Controls.Find("textBox" + (i+1), true)[0];
                ComboBox cbPr = (ComboBox)this.Controls.Find("cb1_" + i + "_" + (i+1), true)[0];

                cbPr.Items.Clear();
                if(tbPr1.Text == "" && tbPr2.Text == "")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if(tbPr1.Text == "-" && tbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if(tbPr1.Text == "" || tbPr1.Text == "-")
                {
                    cbPr.Items.Insert(0, tbPr2.Text);
                }
                else if(tbPr2.Text == "" || tbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, tbPr1.Text);
                }
                else
                {
                    cbPr.Items.Insert(0, tbPr1.Text);
                    cbPr.Items.Insert(1, tbPr2.Text);
                }
                cbPr.SelectedIndex = 0;
            }
        }

        private void tbRez2_1_16_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 16; i += 2)
            {
                ComboBox cbPr1 = (ComboBox)this.Controls.Find("cb1_" + ((2*i)-1)  + "_" + (2*i), true)[0];
                ComboBox cbPr2 = (ComboBox)this.Controls.Find("cb1_" + ((2 * i) + 1) + "_" + ((2 * i) + 2), true)[0];
                ComboBox cbPr = (ComboBox)this.Controls.Find("cb2_" + i + "_" + (i + 1), true)[0];

                cbPr.Items.Clear();
                if (cbPr1.Text == "" && cbPr2.Text == "")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "-" && cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "" || cbPr1.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr2.Text);
                }
                else if (cbPr2.Text == "" || cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                }
                else
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                    cbPr.Items.Insert(1, cbPr2.Text);
                }
                cbPr.SelectedIndex = 0;
            }
        }

        private void tbRez3_1_8_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 8; i += 2)
            {
                ComboBox cbPr1 = (ComboBox)this.Controls.Find("cb2_" + ((2 * i) - 1) + "_" + (2 * i), true)[0];
                ComboBox cbPr2 = (ComboBox)this.Controls.Find("cb2_" + ((2 * i) + 1) + "_" + ((2 * i) + 2), true)[0];
                ComboBox cbPr = (ComboBox)this.Controls.Find("cb3_" + i + "_" + (i + 1), true)[0];

                cbPr.Items.Clear();
                if (cbPr1.Text == "" && cbPr2.Text == "")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "-" && cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "" || cbPr1.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr2.Text);
                }
                else if (cbPr2.Text == "" || cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                }
                else
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                    cbPr.Items.Insert(1, cbPr2.Text);
                }
                cbPr.SelectedIndex = 0;
            }
        }

        private void tbRez4_1_4_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 4; i += 2)
            {
                ComboBox cbPr1 = (ComboBox)this.Controls.Find("cb3_" + ((2 * i) - 1) + "_" + (2 * i), true)[0];
                ComboBox cbPr2 = (ComboBox)this.Controls.Find("cb3_" + ((2 * i) + 1) + "_" + ((2 * i) + 2), true)[0];
                ComboBox cbPr = (ComboBox)this.Controls.Find("cb4_" + i + "_" + (i + 1), true)[0];

                cbPr.Items.Clear();
                if (cbPr1.Text == "" && cbPr2.Text == "")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "-" && cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "" || cbPr1.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr2.Text);
                }
                else if (cbPr2.Text == "" || cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                }
                else
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                    cbPr.Items.Insert(1, cbPr2.Text);
                }
                cbPr.SelectedIndex = 0;
            }
        }

        private void tbRez5_1_2_TextChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < 2; i += 2)
            {
                ComboBox cbPr1 = (ComboBox)this.Controls.Find("cb4_" + ((2 * i) - 1) + "_" + (2 * i), true)[0];
                ComboBox cbPr2 = (ComboBox)this.Controls.Find("cb4_" + ((2 * i) + 1) + "_" + ((2 * i) + 2), true)[0];
                ComboBox cbPr = (ComboBox)this.Controls.Find("cb5_" + i + "_" + (i + 1), true)[0];

                cbPr.Items.Clear();
                if (cbPr1.Text == "" && cbPr2.Text == "")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "-" && cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, "-");
                }
                else if (cbPr1.Text == "" || cbPr1.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr2.Text);
                }
                else if (cbPr2.Text == "" || cbPr2.Text == "-")
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                }
                else
                {
                    cbPr.Items.Insert(0, cbPr1.Text);
                    cbPr.Items.Insert(1, cbPr2.Text);
                }
                cbPr.SelectedIndex = 0;
            }
        }

        private void textBox1_32_LostFocus(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_32_Leave(object sender, EventArgs e)
        {
            for(int i = 1; i <= brIgraca; i++)
            {
                TextBox tbPr = (TextBox)this.Controls.Find("textBox" + i.ToString(), true)[0];
                if((sender as TextBox).Name != tbPr.Name && (sender as TextBox).Text == tbPr.Text && tbPr.Text != "")
                {
                    MessageBox.Show("Postoje dva ista igrača u turniru!", "Upozorenje");
                    break;
                }
            }

            //foreach (string name in svaPrezIme)
            //{
            //    trenutnaPrezIme.Add(name);
            //}
            //for (int i = 1; i <= brIgraca; i++)
            //{
            //    TextBox tbPr = (TextBox)this.Controls.Find("textBox" + i.ToString(), true)[0];
            //    if (tbPr.Text != "")
            //    {
            //        trenutnaPrezIme.Remove(tbPr.Text);
            //    }
            //}
            //for (int i = 1; i <= brIgraca; i++)
            //{
            //    TextBox tbPr = (TextBox)this.Controls.Find("textBox" + i.ToString(), true)[0];
            //    tbPr.AutoCompleteCustomSource = trenutnaPrezIme;
            //}
        }
    }
}
