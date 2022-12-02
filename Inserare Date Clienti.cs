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
    public partial class Inserare_Date_Clienti : Form    {
        string l;
        string p;
        public Inserare_Date_Clienti()
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
            String nm;
            String pren;
            String cnpp;
            String nrt;
            String adr;
            int var;
            try
            {


                nm = numcl.Text;
                pren = prencl.Text;
                cnpp = cnpcl.Text;
                nrt = nrtelcl.Text;
                adr = adresa.Text;
                var = Convert.ToInt32(varcl.Text);

                sql = " INSERT INTO Client(Nume_client,Pren_client,Cnp,Nr_telefon,Adresa,Varsta) VALUES(" + "'" + nm + "','" + pren + "','" + cnpp + "','" + nrt + "','" + adr + "'," + var + ")";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("Datele lipsesc sau sunt introduse gresit !", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cnn.Close();
            numcl.Clear();
            prencl.Clear();
            cnpcl.Clear();
            nrtelcl.Clear();
            adresa.Clear();
            varcl.Clear();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inserare_Date_Contracte_Load(object sender, EventArgs e)
        {

        }
    }
}
