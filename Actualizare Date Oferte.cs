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
    public partial class Actualizare_Date_Oferte: Form
    {
        string l;
        string p;
        public Actualizare_Date_Oferte()
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
            catch{
                MessageBox.Show("Eroare la conectare cu baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            String valoare;
            int ido;
            try
            {
                ido = Convert.ToInt32(idfil.Text);
                valoare = val.Text;

                if (sumimp.Checked)
                {
                    sql = "UPDATE  Oferte SET Suma_imprumutului =" + valoare + " WHERE Id_oferta =" + ido + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (term.Checked)
                {
                    sql = "UPDATE  Oferte SET Termenul_credit =" + valoare + " WHERE Id_oferta =" + ido + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                if (rata.Checked)
                {
                    sql = "UPDATE  Oferte SET Rata_lunara =" + valoare + " WHERE Id_oferta =" + ido + ";";
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
            idfil.Clear(); 
           



        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }
    }
}
