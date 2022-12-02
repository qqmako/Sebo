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
    public partial class Tabela_Clienti : Form
    {
        public Tabela_Clienti()
        {
            InitializeComponent();
        }

        private void Tabela_Clienti_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet4.Client' table. You can move, or remove it, as needed.
                this.clientTableAdapter.Fill(this.seboDataSet4.Client);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
