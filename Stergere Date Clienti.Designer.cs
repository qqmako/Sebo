﻿
namespace Sebo1
{
    partial class Stergere_Date_Clienti
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
            this.delete = new System.Windows.Forms.Button();
            this.ida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.afishc = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.afishc)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(122, 103);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(105, 42);
            this.delete.TabIndex = 2;
            this.delete.Text = "Sterge";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.insert_Click);
            // 
            // ida
            // 
            this.ida.Location = new System.Drawing.Point(122, 22);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(165, 20);
            this.ida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Client:";
            // 
            // afishc
            // 
            this.afishc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afishc.Location = new System.Drawing.Point(310, 22);
            this.afishc.Name = "afishc";
            this.afishc.Size = new System.Drawing.Size(434, 160);
            this.afishc.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(639, 220);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(105, 42);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Stergere_Date_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(786, 274);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.afishc);
            this.Controls.Add(this.ida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delete);
            this.Name = "Stergere_Date_Clienti";
            this.Text = "Stergere Date Angajati";
            this.Load += new System.EventHandler(this.Inserare_Date_Companie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afishc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox ida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView afishc;
        private System.Windows.Forms.Button refresh;
    }
}