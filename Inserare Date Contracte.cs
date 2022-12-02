﻿using System;
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
    public partial class Inserare_Date_Contracte : Form
    {
        string l;
        string p;
        public Inserare_Date_Contracte()
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
            int ang;
            int cl;
            int of;
            String data;
            try
            {


                ang = Convert.ToInt32(idang.Text);
                cl = Convert.ToInt32(idcl.Text);
                of = Convert.ToInt32(idof.Text);
                data = dataim.Text;

                sql = "INSERT INTO Contract(Id_angajat,Id_client,Id_oferta,Data_imprumutului) VALUES(" + ang + "," + cl + "," + of + ",'" + data + "')";
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
            idang.Clear();
            idcl.Clear();
            idof.Clear();
            dataim.Clear();

            

        }
    }
}
