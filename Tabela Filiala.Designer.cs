
namespace Sebo1
{
    partial class Tabela_Filiala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela_Filiala));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfilialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orasulfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filialaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet1 = new Sebo1.SeboDataSet1();
            this.seboDataSet = new Sebo1.SeboDataSet();
            this.seboDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filialaTableAdapter = new Sebo1.SeboDataSet1TableAdapters.FilialaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSetBindingSource)).BeginInit();
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
            this.idfilialaDataGridViewTextBoxColumn,
            this.idcompanieDataGridViewTextBoxColumn,
            this.orasulfilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filialaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // idfilialaDataGridViewTextBoxColumn
            // 
            this.idfilialaDataGridViewTextBoxColumn.DataPropertyName = "Id_filiala";
            this.idfilialaDataGridViewTextBoxColumn.HeaderText = "Id_filiala";
            this.idfilialaDataGridViewTextBoxColumn.Name = "idfilialaDataGridViewTextBoxColumn";
            this.idfilialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcompanieDataGridViewTextBoxColumn
            // 
            this.idcompanieDataGridViewTextBoxColumn.DataPropertyName = "Id_companie";
            this.idcompanieDataGridViewTextBoxColumn.HeaderText = "Id_companie";
            this.idcompanieDataGridViewTextBoxColumn.Name = "idcompanieDataGridViewTextBoxColumn";
            // 
            // orasulfilDataGridViewTextBoxColumn
            // 
            this.orasulfilDataGridViewTextBoxColumn.DataPropertyName = "Orasul_fil";
            this.orasulfilDataGridViewTextBoxColumn.HeaderText = "Orasul_fil";
            this.orasulfilDataGridViewTextBoxColumn.Name = "orasulfilDataGridViewTextBoxColumn";
            // 
            // filialaBindingSource
            // 
            this.filialaBindingSource.DataMember = "Filiala";
            this.filialaBindingSource.DataSource = this.seboDataSet1;
            // 
            // seboDataSet1
            // 
            this.seboDataSet1.DataSetName = "SeboDataSet1";
            this.seboDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seboDataSet
            // 
            this.seboDataSet.DataSetName = "SeboDataSet";
            this.seboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seboDataSetBindingSource
            // 
            this.seboDataSetBindingSource.DataSource = this.seboDataSet;
            this.seboDataSetBindingSource.Position = 0;
            // 
            // filialaTableAdapter
            // 
            this.filialaTableAdapter.ClearBeforeFill = true;
            // 
            // Tabela_Filiala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabela_Filiala";
            this.Text = "Tabela_Filiala";
            this.Load += new System.EventHandler(this.Tabela_Filiala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource seboDataSetBindingSource;
        private SeboDataSet seboDataSet;
        private SeboDataSet1 seboDataSet1;
        private System.Windows.Forms.BindingSource filialaBindingSource;
        private SeboDataSet1TableAdapters.FilialaTableAdapter filialaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfilialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orasulfilDataGridViewTextBoxColumn;
    }
}