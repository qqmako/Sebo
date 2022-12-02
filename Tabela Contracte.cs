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
    public partial class Tabela_Contracte : Form
    {
        public Tabela_Contracte()
        {
            InitializeComponent();
        }

        private void Tabela_Contracte_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet5.Contract' table. You can move, or remove it, as needed.
                this.contractTableAdapter.Fill(this.seboDataSet5.Contract);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
