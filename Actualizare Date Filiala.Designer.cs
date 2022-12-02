
namespace Sebo1
{
    partial class Actualizare_Date_Filiala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizare_Date_Filiala));
            this.label1 = new System.Windows.Forms.Label();
            this.idcom = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.idfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orfil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Companie nou :";
            // 
            // idcom
            // 
            this.idcom.Location = new System.Drawing.Point(178, 76);
            this.idcom.Name = "idcom";
            this.idcom.Size = new System.Drawing.Size(165, 20);
            this.idcom.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(178, 181);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 42);
            this.update.TabIndex = 2;
            this.update.Text = "Actualizare";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.insert_Click);
            // 
            // idfil
            // 
            this.idfil.Location = new System.Drawing.Point(178, 20);
            this.idfil.Name = "idfil";
            this.idfil.Size = new System.Drawing.Size(165, 20);
            this.idfil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Filiala:";
            // 
            // orfil
            // 
            this.orfil.Location = new System.Drawing.Point(178, 123);
            this.orfil.Name = "orfil";
            this.orfil.Size = new System.Drawing.Size(165, 20);
            this.orfil.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orasul Filiala nou:";
            // 
            // Actualizare_Date_Filiala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(490, 324);
            this.Controls.Add(this.orfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.idcom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizare_Date_Filiala";
            this.Text = "Actualizare Date Filiala";
            this.Load += new System.EventHandler(this.Inserare_Date_Companie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idcom;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox idfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orfil;
        private System.Windows.Forms.Label label3;
    }
}