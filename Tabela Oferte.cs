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
    public partial class Tabela_Oferte : Form
    {
        public Tabela_Oferte()
        {
            InitializeComponent();
        }

        private void Tabela_Oferte_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'seboDataSet2.Oferte' table. You can move, or remove it, as needed.
                this.oferteTableAdapter.Fill(this.seboDataSet2.Oferte);
            }
            catch
            {
                MessageBox.Show("Ceva nu a mers... Incercati din nou !", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        }
    }

