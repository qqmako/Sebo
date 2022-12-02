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
    public partial class Inserare_Date_Angajati : Form
    {
        string l;
        string p;
        public Inserare_Date_Angajati()
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
            string numa;
            string prena;
            string nrt;
            string ad;
            int sala;
            try
            {


                idf = Convert.ToInt32(idfil.Text);
                numa = numang.Text;
                prena = prenang.Text;
                nrt = nrtel.Text;
                ad = adresa.Text;
                sala = Convert.ToInt32(sal.Text);



                sql = " INSERT INTO Angajati(Id_filiala,Nume_angajat,Pren_angjat,Nr_telefon,Adresa,Salariu) VALUES(" + idf + ",'" + numa + "','" + prena + "','" + nrt + "','" + ad + "'," + sala + ")";
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
            idfil.Clear();numang.Clear();
            prenang.Clear();
            nrtel.Clear();
            adresa.Clear();
            sal.Clear();
            

        }
    }
}
