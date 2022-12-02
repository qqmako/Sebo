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
    public partial class Actualizare_Date_Angajati: Form
    {
        string l;
        string p;
        public Actualizare_Date_Angajati()
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
            String valoare = ""; 
            int id = 0;

            try
            {
                id = Convert.ToInt32(ida.Text);
                valoare = val.Text;


                if (idf.Checked)
                {
                    sql = "UPDATE  Angajati SET Id_filiala =" + valoare + " WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (nma.Checked)
                {
                    sql = "UPDATE  Angajati SET Nume_client ='" + valoare + "' WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (prna.Checked)
                {
                    sql = "UPDATE  Angajati SET Pren_angajat = '" + valoare + "' WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (nrta.Checked)
                {
                    sql = "UPDATE  Angajati SET Nr_telefon = '" + valoare + "' WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (ada.Checked)
                {
                    sql = "UPDATE  Angajati SET Adresa = '" + valoare + "' WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (sala.Checked)
                {
                    sql = "UPDATE  Angajati SET Salariu =" + valoare + " WHERE  Id_angajat =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch
            {
                
                MessageBox.Show("Datele lipsesc sau sunt introduse gresit !", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            
            
            
            cnn.Close();
            val.Clear();
            ida.Clear();




        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }

        private void ida_TextChanged(object sender, EventArgs e)
        {

        }

        private void idf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void prna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nrta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void val_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
