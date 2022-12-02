
namespace Sebo1
{
    partial class Actualizare_Date_Angajati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizare_Date_Angajati));
            this.label1 = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.ida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sala = new System.Windows.Forms.RadioButton();
            this.ada = new System.Windows.Forms.RadioButton();
            this.nrta = new System.Windows.Forms.RadioButton();
            this.prna = new System.Windows.Forms.RadioButton();
            this.nma = new System.Windows.Forms.RadioButton();
            this.idf = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoarea noua:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(207, 245);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(165, 20);
            this.val.TabIndex = 1;
            this.val.TextChanged += new System.EventHandler(this.val_TextChanged);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(207, 311);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(130, 40);
            this.update.TabIndex = 2;
            this.update.Text = "Actualizare";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.insert_Click);
            // 
            // ida
            // 
            this.ida.Location = new System.Drawing.Point(207, 23);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(165, 20);
            this.ida.TabIndex = 4;
            this.ida.TextChanged += new System.EventHandler(this.ida_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Angajat:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sala);
            this.groupBox1.Controls.Add(this.ada);
            this.groupBox1.Controls.Add(this.nrta);
            this.groupBox1.Controls.Add(this.prna);
            this.groupBox1.Controls.Add(this.nma);
            this.groupBox1.Controls.Add(this.idf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(44, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegeti ce camp trebuie actualizat";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sala
            // 
            this.sala.AutoSize = true;
            this.sala.Location = new System.Drawing.Point(220, 113);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(88, 26);
            this.sala.TabIndex = 5;
            this.sala.TabStop = true;
            this.sala.Text = "Salariul";
            this.sala.UseVisualStyleBackColor = true;
            this.sala.CheckedChanged += new System.EventHandler(this.sala_CheckedChanged);
            // 
            // ada
            // 
            this.ada.AutoSize = true;
            this.ada.Location = new System.Drawing.Point(220, 68);
            this.ada.Name = "ada";
            this.ada.Size = new System.Drawing.Size(84, 26);
            this.ada.TabIndex = 4;
            this.ada.TabStop = true;
            this.ada.Text = "Adresa";
            this.ada.UseVisualStyleBackColor = true;
            this.ada.CheckedChanged += new System.EventHandler(this.ada_CheckedChanged);
            // 
            // nrta
            // 
            this.nrta.AutoSize = true;
            this.nrta.Location = new System.Drawing.Point(220, 27);
            this.nrta.Name = "nrta";
            this.nrta.Size = new System.Drawing.Size(189, 26);
            this.nrta.TabIndex = 3;
            this.nrta.TabStop = true;
            this.nrta.Text = "Numarul de Telefon";
            this.nrta.UseVisualStyleBackColor = true;
            this.nrta.CheckedChanged += new System.EventHandler(this.nrta_CheckedChanged);
            // 
            // prna
            // 
            this.prna.AutoSize = true;
            this.prna.Location = new System.Drawing.Point(14, 113);
            this.prna.Name = "prna";
            this.prna.Size = new System.Drawing.Size(168, 26);
            this.prna.TabIndex = 2;
            this.prna.TabStop = true;
            this.prna.Text = "Prenume Angajat";
            this.prna.UseVisualStyleBackColor = true;
            this.prna.CheckedChanged += new System.EventHandler(this.prna_CheckedChanged);
            // 
            // nma
            // 
            this.nma.AutoSize = true;
            this.nma.Location = new System.Drawing.Point(14, 68);
            this.nma.Name = "nma";
            this.nma.Size = new System.Drawing.Size(145, 26);
            this.nma.TabIndex = 1;
            this.nma.TabStop = true;
            this.nma.Text = "Nume Angajat";
            this.nma.UseVisualStyleBackColor = true;
            this.nma.CheckedChanged += new System.EventHandler(this.nma_CheckedChanged);
            // 
            // idf
            // 
            this.idf.AutoSize = true;
            this.idf.Location = new System.Drawing.Point(14, 27);
            this.idf.Name = "idf";
            this.idf.Size = new System.Drawing.Size(96, 26);
            this.idf.TabIndex = 0;
            this.idf.TabStop = true;
            this.idf.Text = "Id Filiala";
            this.idf.UseVisualStyleBackColor = true;
            this.idf.CheckedChanged += new System.EventHandler(this.idf_CheckedChanged);
            // 
            // Actualizare_Date_Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(490, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.val);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizare_Date_Angajati";
            this.Text = "Actualizare Date Angajati";
            this.Load += new System.EventHandler(this.Inserare_Date_Companie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox val;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox ida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton prna;
        private System.Windows.Forms.RadioButton nma;
        private System.Windows.Forms.RadioButton idf;
        private System.Windows.Forms.RadioButton sala;
        private System.Windows.Forms.RadioButton ada;
        private System.Windows.Forms.RadioButton nrta;
    }
}