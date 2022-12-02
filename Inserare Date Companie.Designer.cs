
namespace Sebo1
{
    partial class Inserare_Date_Companie
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
            this.insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Companie:";
            // 
            // nmcomp
            // 
            this.nmcomp.Location = new System.Drawing.Point(186, 37);
            this.nmcomp.Name = "nmcomp";
            this.nmcomp.Size = new System.Drawing.Size(165, 20);
            this.nmcomp.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert.Location = new System.Drawing.Point(209, 112);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(105, 42);
            this.insert.TabIndex = 2;
            this.insert.Text = "Inserare";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // Inserare_Date_Companie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.nmcomp);
            this.Controls.Add(this.label1);
            this.Name = "Inserare_Date_Companie";
            this.Text = "Inserare_Date_Companie";
            this.Load += new System.EventHandler(this.Inserare_Date_Companie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nmcomp;
        private System.Windows.Forms.Button insert;
    }
}