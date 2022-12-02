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
//using System.Data.SqlClient;

namespace Sebo1
{
    public partial class Stergere_Date_Filiala : Form
    {
        string l;
        string p;
        const string quote = "\"";
        public Stergere_Date_Filiala()
        {
            InitializeComponent();
            this.l = Form1.loginul;
            this.p = Form1.parola;
        }

        private void insert_Click(object sender, EventArgs e)
        {



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
            int idc;
            try { 
            
            idc = Convert.ToInt32(idcom.Text);

            sql = "DELETE Filiala WHERE Id_filiala = " + idc + ";";
            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
        } 
        catch
            {
                MessageBox.Show("Datele lipsesc sau sunt introduse gresit !", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
    cnn.Close();          
            idcom.Clear();
            



        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conn = new SqlConnection("Data Source = ASUS-GFX; Initial Catalog = Sebo; User ID = " + quote + l + quote + "; Password = " + quote + p + quote + ";");
                conn.Open();
                SqlDataAdapter sql = new SqlDataAdapter("SELECT * FROM Filiala;", conn);
                DataTable t1 = new DataTable();
                sql.Fill(t1);
                afishc.DataSource = t1;
            }
            catch
            {
                MessageBox.Show("Eroare la extragerea informatiei din tabela !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void idf_Click(object sender, EventArgs e)
        {

        }
    }
}
