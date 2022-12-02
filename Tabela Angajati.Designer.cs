
namespace Sebo1
{
    partial class Tabela_Angajati
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela_Angajati));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfilialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenangjatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet3 = new Sebo1.SeboDataSet3();
            this.angajatiTableAdapter = new Sebo1.SeboDataSet3TableAdapters.AngajatiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idangajatDataGridViewTextBoxColumn,
            this.idfilialaDataGridViewTextBoxColumn,
            this.numeangajatDataGridViewTextBoxColumn,
            this.prenangjatDataGridViewTextBoxColumn,
            this.nrtelefonDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.salariuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.angajatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // idangajatDataGridViewTextBoxColumn
            // 
            this.idangajatDataGridViewTextBoxColumn.DataPropertyName = "Id_angajat";
            this.idangajatDataGridViewTextBoxColumn.HeaderText = "Id_angajat";
            this.idangajatDataGridViewTextBoxColumn.Name = "idangajatDataGridViewTextBoxColumn";
            this.idangajatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idfilialaDataGridViewTextBoxColumn
            // 
            this.idfilialaDataGridViewTextBoxColumn.DataPropertyName = "Id_filiala";
            this.idfilialaDataGridViewTextBoxColumn.HeaderText = "Id_filiala";
            this.idfilialaDataGridViewTextBoxColumn.Name = "idfilialaDataGridViewTextBoxColumn";
            // 
            // numeangajatDataGridViewTextBoxColumn
            // 
            this.numeangajatDataGridViewTextBoxColumn.DataPropertyName = "Nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.HeaderText = "Nume_angajat";
            this.numeangajatDataGridViewTextBoxColumn.Name = "numeangajatDataGridViewTextBoxColumn";
            // 
            // prenangjatDataGridViewTextBoxColumn
            // 
            this.prenangjatDataGridViewTextBoxColumn.DataPropertyName = "Pren_angjat";
            this.prenangjatDataGridViewTextBoxColumn.HeaderText = "Pren_angjat";
            this.prenangjatDataGridViewTextBoxColumn.Name = "prenangjatDataGridViewTextBoxColumn";
            // 
            // nrtelefonDataGridViewTextBoxColumn
            // 
            this.nrtelefonDataGridViewTextBoxColumn.DataPropertyName = "Nr_telefon";
            this.nrtelefonDataGridViewTextBoxColumn.HeaderText = "Nr_telefon";
            this.nrtelefonDataGridViewTextBoxColumn.Name = "nrtelefonDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // salariuDataGridViewTextBoxColumn
            // 
            this.salariuDataGridViewTextBoxColumn.DataPropertyName = "Salariu";
            this.salariuDataGridViewTextBoxColumn.HeaderText = "Salariu";
            this.salariuDataGridViewTextBoxColumn.Name = "salariuDataGridViewTextBoxColumn";
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.seboDataSet3;
            // 
            // seboDataSet3
            // 
            this.seboDataSet3.DataSetName = "SeboDataSet3";
            this.seboDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // Tabela_Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabela_Angajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela_Angajati";
            this.Load += new System.EventHandler(this.Tabela_Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SeboDataSet3 seboDataSet3;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private SeboDataSet3TableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfilialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenangjatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuDataGridViewTextBoxColumn;
    }
}