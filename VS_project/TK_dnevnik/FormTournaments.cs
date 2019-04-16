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
    public partial class FormTournaments : Form
    {
        public FormTournaments()
        {
            InitializeComponent();
        }

        private void FormTournaments_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.tournamentsOpen = false;
        }
    }
}
