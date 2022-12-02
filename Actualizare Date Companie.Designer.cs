
namespace Sebo1
{
    partial class Actualizare_Date_Companie
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
            this.label1 = new System.Windows.Forms.Label();
            this.nmcomp = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.idcom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Companie nou:";
            // 
            // nmcomp
            // 
            this.nmcomp.Location = new System.Drawing.Point(207, 79);
            this.nmcomp.Name = "nmcomp";
            this.nmcomp.Size = new System.Drawing.Size(165, 20);
            this.nmcomp.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(207, 131);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 42);
            this.update.TabIndex = 2;
            this.update.Text = "Actualizare";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.insert_Click);
            // 
            // idcom
            // 
            this.idcom.Location = new System.Drawing.Point(207, 23);
            this.idcom.Name = "idcom";
            this.idcom.Size = new System.Drawing.Size(165, 20);
            this.idcom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Companie:";
            // 
            // Actualizare_Date_Companie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.idcom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.nmcomp);
            this.Controls.Add(this.label1);
            this.Name = "Actualizare_Date_Companie";
            this.Text = "Inserare Date Companie";
            this.Load += new System.EventHandler(this.Inserare_Date_Companie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nmcomp;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox idcom;
        private System.Windows.Forms.Label label2;
    }
}