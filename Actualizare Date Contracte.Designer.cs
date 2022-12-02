
namespace Sebo1
{
    partial class Actualizare_Date_Contracte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizare_Date_Contracte));
            this.label1 = new System.Windows.Forms.Label();
            this.val = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.idc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.RadioButton();
            this.ido = new System.Windows.Forms.RadioButton();
            this.idcl = new System.Windows.Forms.RadioButton();
            this.ida = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoarea noua:";
            // 
            // val
            // 
            this.val.Location = new System.Drawing.Point(207, 213);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(165, 20);
            this.val.TabIndex = 1;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(207, 276);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 42);
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
            this.label2.Location = new System.Drawing.Point(95, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Contract:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.ido);
            this.groupBox1.Controls.Add(this.idcl);
            this.groupBox1.Controls.Add(this.ida);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(44, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegeti ce camp trebuie actualizat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(198, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "[ aaaa-ll-zz ]";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(181, 68);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(183, 26);
            this.data.TabIndex = 3;
            this.data.TabStop = true;
            this.data.Text = "Data Imprumutului";
            this.data.UseVisualStyleBackColor = true;
            // 
            // ido
            // 
            this.ido.AutoSize = true;
            this.ido.Location = new System.Drawing.Point(181, 27);
            this.ido.Name = "ido";
            this.ido.Size = new System.Drawing.Size(100, 26);
            this.ido.TabIndex = 2;
            this.ido.TabStop = true;
            this.ido.Text = "Id Oferta";
            this.ido.UseVisualStyleBackColor = true;
            // 
            // idcl
            // 
            this.idcl.AutoSize = true;
            this.idcl.Location = new System.Drawing.Point(14, 68);
            this.idcl.Name = "idcl";
            this.idcl.Size = new System.Drawing.Size(96, 26);
            this.idcl.TabIndex = 1;
            this.idcl.TabStop = true;
            this.idcl.Text = "Id Client";
            this.idcl.UseVisualStyleBackColor = true;
            // 
            // ida
            // 
            this.ida.AutoSize = true;
            this.ida.Location = new System.Drawing.Point(14, 27);
            this.ida.Name = "ida";
            this.ida.Size = new System.Drawing.Size(112, 26);
            this.ida.TabIndex = 0;
            this.ida.TabStop = true;
            this.ida.Text = "Id Angajat";
            this.ida.UseVisualStyleBackColor = true;
            // 
            // Actualizare_Date_Contracte
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
            this.Name = "Actualizare_Date_Contracte";
            this.Text = "Actualizare Date Contract";
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
        private System.Windows.Forms.RadioButton ido;
        private System.Windows.Forms.RadioButton idcl;
        private System.Windows.Forms.RadioButton ida;
        private System.Windows.Forms.RadioButton data;
        private System.Windows.Forms.Label label3;
    }
}