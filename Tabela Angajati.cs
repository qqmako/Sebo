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
    public partial class Tabela_Angajati : Form
    {
        public Tabela_Angajati()
        {
            InitializeComponent();
        }

        private void Tabela_Angajati_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet3.Angajati' table. You can move, or remove it, as needed.
                this.angajatiTableAdapter.Fill(this.seboDataSet3.Angajati);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
