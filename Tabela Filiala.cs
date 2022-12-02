using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebo1
{
    public partial class Tabela_Filiala : Form
    {
        public Tabela_Filiala()
        {
            InitializeComponent();
        }

        private void Tabela_Filiala_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet1.Filiala' table. You can move, or remove it, as needed.
                this.filialaTableAdapter.Fill(this.seboDataSet1.Filiala);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
