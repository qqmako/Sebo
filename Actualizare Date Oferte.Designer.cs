
namespace Sebo1
{
    partial class Actualizare_Date_Oferte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizare_Date_Oferte));
            this.label1 = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.idfil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rata = new System.Windows.Forms.RadioButton();
            this.term = new System.Windows.Forms.RadioButton();
            this.sumimp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoarea noua:";
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(182, 173);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(165, 20);
            this.val.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(182, 239);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 42);
            this.update.TabIndex = 2;
            this.update.Text = "Actualizare";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.insert_Click);
            // 
            // idfil
            // 
            this.idfil.Location = new System.Drawing.Point(182, 21);
            this.idfil.Name = "idfil";
            this.idfil.Size = new System.Drawing.Size(165, 20);
            this.idfil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Oferta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rata);
            this.groupBox1.Controls.Add(this.term);
            this.groupBox1.Controls.Add(this.sumimp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegeti ce camp trebuie actualizat";
            // 
            // rata
            // 
            this.rata.AutoSize = true;
            this.rata.Location = new System.Drawing.Point(245, 27);
            this.rata.Name = "rata";
            this.rata.Size = new System.Drawing.Size(123, 26);
            this.rata.TabIndex = 2;
            this.rata.TabStop = true;
            this.rata.Text = "Rata Lunara";
            this.rata.UseVisualStyleBackColor = true;
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(14, 68);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(184, 26);
            this.term.TabIndex = 1;
            this.term.TabStop = true;
            this.term.Text = "Termenul de Credit";
            this.term.UseVisualStyleBackColor = true;
            // 
            // sumimp
            // 
            this.sumimp.AutoSize = true;
            this.sumimp.Location = new System.Drawing.Point(14, 27);
            this.sumimp.Name = "sumimp";
            this.sumimp.Size = new System.Drawing.Size(190, 26);
            this.sumimp.TabIndex = 0;
            this.sumimp.TabStop = true;
            this.sumimp.Text = "Suma Imprumutului";
            this.sumimp.UseVisualStyleBackColor = true;
            // 
            // Actualizare_Date_Oferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(490, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.val);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizare_Date_Oferte";
            this.Text = "Actualizare Date Oferte";
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
        private System.Windows.Forms.TextBox idfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rata;
        private System.Windows.Forms.RadioButton term;
        private System.Windows.Forms.RadioButton sumimp;
    }
}