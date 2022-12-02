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
    public partial class Tabelul_Companie : Form
    {
        public Tabelul_Companie()
        {
            InitializeComponent();
        }

        private void Tabelul_Companie_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet.Companie' table. You can move, or remove it, as needed.
                this.companieTableAdapter.Fill(this.seboDataSet.Companie);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
