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
    public partial class FormMain : Form
    {
        public static SqlConnection myConnection;
        public static SqlDataAdapter myDbDataAdapter;
        public static string myConnectionString = ConfigurationManager.ConnectionStrings["database1ConnectionString"].ConnectionString;

        public static Boolean playersOpen = false;
        public static Boolean tournamentsOpen = false;
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            if(!playersOpen)
            {
                FormPlayers playersF = new FormPlayers();
                playersF.Show();
                playersOpen = true;
            }
            else
            {
                MessageBox.Show("Prozor Igrači je već otvoren", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void btnTournaments_Click(object sender, EventArgs e)
        {
            if (!tournamentsOpen)
            {
                FormTournaments tournamentsF = new FormTournaments();
                tournamentsF.Show();
                tournamentsOpen = true;
            }
            else
            {
                MessageBox.Show("Prozor Turniri je već otvoren", "Upozorenje", MessageBoxButtons.OK);
            }
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mssg;
            mssg = "Ova aplikacija je napravljena u svrhu lakšeg vođenja teniskih turnira.\n";
            mssg += "Kroz aplikaciju se može viditi evidencija o igračima te svim odigranim mečevima unutar unesenih turnira.\n\n";
            mssg += "Za upute korištenja kliknite na Pomoć -> Kako se koristi\n";
            mssg += "Za kontakt autora kliknite na Pomoć -> Kontakt";
            MessageBox.Show(mssg, "O aplikaciji");
        }

        private void kontaktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mssg;
            mssg = "Aplikaciju izradio: Domagoj Karl\n";
            mssg += "E-mail: karl.domagoj@gmail.com\n";
            MessageBox.Show(mssg, "Kontakt");
        }

        private void zatvoriAplikacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeste li sigurni da ste spremili sve promjene i da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Jeste li sigurni da ste spremili sve promjene i da želite zatvoriti aplikaciju?", "Upozorenje", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
