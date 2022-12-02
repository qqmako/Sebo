
namespace Sebo1
{
    partial class Actualizare_Date_Clienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizare_Date_Clienti));
            this.label1 = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.idc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.varc = new System.Windows.Forms.RadioButton();
            this.ada = new System.Windows.Forms.RadioButton();
            this.nrta = new System.Windows.Forms.RadioButton();
            this.cnpc = new System.Windows.Forms.RadioButton();
            this.prnc = new System.Windows.Forms.RadioButton();
            this.nmc = new System.Windows.Forms.RadioButton();
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
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(207, 245);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(165, 20);
            this.val.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(207, 311);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 42);
            this.update.TabIndex = 2;
            this.update.Text = "Actualizare";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.insert_Click);
            // 
            // idc
            // 
            this.idc.Location = new System.Drawing.Point(207, 23);
            this.idc.Name = "idc";
            this.idc.Size = new System.Drawing.Size(165, 20);
            this.idc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(108, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Client:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.varc);
            this.groupBox1.Controls.Add(this.ada);
            this.groupBox1.Controls.Add(this.nrta);
            this.groupBox1.Controls.Add(this.cnpc);
            this.groupBox1.Controls.Add(this.prnc);
            this.groupBox1.Controls.Add(this.nmc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(44, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegeti ce camp trebuie actualizat";
            // 
            // varc
            // 
            this.varc.AutoSize = true;
            this.varc.Location = new System.Drawing.Point(220, 113);
            this.varc.Name = "varc";
            this.varc.Size = new System.Drawing.Size(79, 26);
            this.varc.TabIndex = 5;
            this.varc.TabStop = true;
            this.varc.Text = "Varsta";
            this.varc.UseVisualStyleBackColor = true;
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
            // 
            // cnpc
            // 
            this.cnpc.AutoSize = true;
            this.cnpc.Location = new System.Drawing.Point(14, 113);
            this.cnpc.Name = "cnpc";
            this.cnpc.Size = new System.Drawing.Size(64, 26);
            this.cnpc.TabIndex = 2;
            this.cnpc.TabStop = true;
            this.cnpc.Text = "CNP";
            this.cnpc.UseVisualStyleBackColor = true;
            // 
            // prnc
            // 
            this.prnc.AutoSize = true;
            this.prnc.Location = new System.Drawing.Point(14, 68);
            this.prnc.Name = "prnc";
            this.prnc.Size = new System.Drawing.Size(152, 26);
            this.prnc.TabIndex = 1;
            this.prnc.TabStop = true;
            this.prnc.Text = "Prenume Client";
            this.prnc.UseVisualStyleBackColor = true;
            // 
            // nmc
            // 
            this.nmc.AutoSize = true;
            this.nmc.Location = new System.Drawing.Point(14, 27);
            this.nmc.Name = "nmc";
            this.nmc.Size = new System.Drawing.Size(129, 26);
            this.nmc.TabIndex = 0;
            this.nmc.TabStop = true;
            this.nmc.Text = "Nume Client";
            this.nmc.UseVisualStyleBackColor = true;
            // 
            // Actualizare_Date_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(490, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.val);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizare_Date_Clienti";
            this.Text = "Actualizare Date Clienti";
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
        private System.Windows.Forms.TextBox idc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cnpc;
        private System.Windows.Forms.RadioButton prnc;
        private System.Windows.Forms.RadioButton nmc;
        private System.Windows.Forms.RadioButton varc;
        private System.Windows.Forms.RadioButton ada;
        private System.Windows.Forms.RadioButton nrta;
    }
}