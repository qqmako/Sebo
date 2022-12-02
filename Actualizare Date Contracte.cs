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
    public partial class Actualizare_Date_Contracte: Form
    {
        string l;
        string p;
        public Actualizare_Date_Contracte()
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
            String valoare;
            int id;
            try
            {
                id = Convert.ToInt32(idc.Text);
                valoare = val.Text;

                if (ida.Checked)
                {
                    sql = "UPDATE  Contract SET Id_angajat = " + Convert.ToInt32(valoare) + " WHERE   Id_contract =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                try
                {
                    if (idcl.Checked)
                    {
                        sql = "UPDATE  Contract SET Id_client = " + Convert.ToInt32(valoare) + " WHERE   Id_contract =" + id + ";";
                        command = new SqlCommand(sql, cnn);

                        adapter.UpdateCommand = new SqlCommand(sql, cnn);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        command.Dispose();
                    }
                }
                catch 
                {
                    MessageBox.Show("Cheia nu poate fi dublicata !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (ido.Checked)
                {
                    sql = "UPDATE  Contract SET Id_oferta = " + Convert.ToInt32(valoare) + " WHERE   Id_contract =" + id + ";";
                    command = new SqlCommand(sql, cnn);

                    adapter.UpdateCommand = new SqlCommand(sql, cnn);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                }


                if (data.Checked)
                {
                    sql = "UPDATE  Contract SET Data_imprumutului = '" + valoare + "' WHERE   Id_contract =" + id + ";";
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
            idc.Clear();




        }

        private void Inserare_Date_Companie_Load(object sender, EventArgs e)
        {

        }
    }
}
