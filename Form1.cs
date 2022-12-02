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
    public partial class Form1 : Form
    {

        public static string loginul { get; set; }
        public static string parola { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void conect_Click(object sender, EventArgs e)
        {
            loginul = login.Text;
            parola = pass.Text;
            if (loginul == "sa" && parola == "123321")
            {
                Pagina_Principala p1 = new Pagina_Principala();
                p1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Parola sau Loginul gresit !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            login.Clear();
            pass.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                conect.PerformClick();
            }
        }
    }
}
