using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebo1
{
    public partial class Inserare_Date_Companie : Form
    {
        string l;
        string p;
        public Inserare_Date_Companie()
        {
            InitializeComponent();
            this.l = Form1.loginul;
            this.p = Form1.parola;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            const string quote = "\"";


            string connetionString;
            SqlConnection cnn;
            String datasursa = "Data Source = ASUS-GFX; Initial Catalog = Sebo; User ID = " + quote + l + quote + "; Password = " + quote + p + quote + ";";

            connetionString = @datasursa;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Eroare la conectare cu baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            String numecompanie;

                numecompanie = nmcomp.Text;

                if (!string.IsNullOrEmpty(numecompanie))
                {

                    sql = "INSERT INTO Companie(Nume_companie) VALUES('" + numecompanie + "')";
                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();

                }
                else
                MessageBox.Show("Datele lipsesc sau sunt introduse gresit !", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            
            cnn.Close();
            nmcomp.Clear();



        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }
    }
}
