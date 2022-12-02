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
    public partial class Pagina_Principala : Form  
    {
        public Pagina_Principala()
        {
            InitializeComponent();
            ascunde();
        }
        private void ascunde()
        {
            paneltabele.Visible = false; //tabele
            panel3.Visible = false; //stergere
            panel2.Visible = false; //actualizare
            panelinsert.Visible = false;
            
        }

        private void ascundeMenu()
        {
            if (paneltabele.Visible == true)
                paneltabele.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panelinsert.Visible == true)
                panelinsert.Visible = false;
        }
        private void arataSmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                ascundeMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

        }




        private void Pagina_Principala_Load(object sender, EventArgs e)
        {

        }

        private void tabele_Click(object sender, EventArgs e)
        {
            arataSmenu(paneltabele);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            arataSmenu(panelinsert);
        }

        private void actualizare_Click(object sender, EventArgs e)
        {
            arataSmenu(panel2);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            arataSmenu(panel3);
        }

        #region Deschiderea formelor

        private void button1_Click(object sender, EventArgs e)
        {
            openChild(new Tabelul_Companie());
            ascundeMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChild(new Tabela_Filiala());
            ascundeMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChild(new Tabela_Oferte());
            ascundeMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChild(new Tabela_Angajati());
            ascundeMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChild(new Tabela_Clienti());
            ascundeMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChild(new Tabela_Contracte());
            ascundeMenu();
        }

        private void insertcompanie_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Companie());
            ascundeMenu();
        }

        private void insertfiliala_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Filiala());
            ascundeMenu();
        }

        private void insertoferte_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Oferte());
            ascundeMenu();
        }

        private void insertangajati_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Angajati());
            ascundeMenu();
        }

        private void insertclienti_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Clienti());
            ascundeMenu();
        }

        private void insertcontracte_Click(object sender, EventArgs e)
        {
            openChild(new Inserare_Date_Contracte());
            ascundeMenu();
        }

        private void actualizarecompanie_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Companie());
            ascundeMenu();
        }

        private void actualizarefiliala_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Filiala());
            ascundeMenu();
        }

        private void actualizareoferte_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Oferte());
            ascundeMenu();
        }

        private void actualizareangajati_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Angajati());
            ascundeMenu();
        }

        private void actualizareclienti_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Clienti());
            ascundeMenu();
        }

        private void actualizarecontracte_Click(object sender, EventArgs e)
        {
            openChild(new Actualizare_Date_Contracte());
            ascundeMenu();
        }

        private void stergecompanie_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Companie());
            ascundeMenu();
        }

        private void stergecomp_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Filiala());
            ascundeMenu();
        }

        private void stergeoferte_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Oferte());
            ascundeMenu();
        }

        private void stergeangajati_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Angajati());
            ascundeMenu();
        }

        private void stergeclienti_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Clienti());
            ascundeMenu();
        }

        private void stergecontracte_Click(object sender, EventArgs e)
        {
            openChild(new Stergere_Date_Contracte());
            ascundeMenu();
        }
        #endregion


        private Form active = null;
        private void openChild(Form child)
        {
            if (active != null)
                active.Close();
            active = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelform.Controls.Add(child);
            panelform.Tag = child;
            child.BringToFront();
            child.Show();

        }

        private void diagrama_Click(object sender, EventArgs e)
        {
            openChild(new Diagrama());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            const string message = "Doriti sa inchideti ?";
            const string caption = "Iesire";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Pagina_Principala_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
