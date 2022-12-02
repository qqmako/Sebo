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
    public partial class Actualizare_Date_Filiala : Form
    {
        string l;
        string p;
        public Actualizare_Date_Filiala()
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
            int idf;
            int idc;
            string orf;
            try
            {
                idf = Convert.ToInt32(idfil.Text);
                idc = Convert.ToInt32(idcom.Text);
                orf = orfil.Text;

                sql = "UPDATE  Filiala SET Id_companie =" + idc + ", Orasul_fil ='" + orf + "' WHERE Id_filiala=" + idf + ";";
                command = new SqlCommand(sql, cnn);

                adapter.UpdateCommand = new SqlCommand(sql, cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("Datele lipsesc sau sunt introduse gresit !", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cnn.Close();
            idcom.Clear();
            idfil.Clear();
            orfil.Clear();



        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }
    }
}
