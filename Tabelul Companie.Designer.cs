
namespace Sebo1
{
    partial class Tabelul_Companie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabelul_Companie));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numecompanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet = new Sebo1.SeboDataSet();
            this.companieTableAdapter = new Sebo1.SeboDataSetTableAdapters.CompanieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).BeginInit();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcompanieDataGridViewTextBoxColumn,
            this.numecompanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idcompanieDataGridViewTextBoxColumn
            // 
            this.idcompanieDataGridViewTextBoxColumn.DataPropertyName = "Id_companie";
            this.idcompanieDataGridViewTextBoxColumn.HeaderText = "Id_companie";
            this.idcompanieDataGridViewTextBoxColumn.Name = "idcompanieDataGridViewTextBoxColumn";
            this.idcompanieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numecompanieDataGridViewTextBoxColumn
            // 
            this.numecompanieDataGridViewTextBoxColumn.DataPropertyName = "Nume_companie";
            this.numecompanieDataGridViewTextBoxColumn.HeaderText = "Nume_companie";
            this.numecompanieDataGridViewTextBoxColumn.Name = "numecompanieDataGridViewTextBoxColumn";
            // 
            // companieBindingSource
            // 
            this.companieBindingSource.DataMember = "Companie";
            this.companieBindingSource.DataSource = this.seboDataSet;
            // 
            // seboDataSet
            // 
            this.seboDataSet.DataSetName = "SeboDataSet";
            this.seboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companieTableAdapter
            // 
            this.companieTableAdapter.ClearBeforeFill = true;
            // 
            // Tabelul_Companie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabelul_Companie";
            this.Text = "Tabelul_Companie";
            this.Load += new System.EventHandler(this.Tabelul_Companie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SeboDataSet seboDataSet;
        private System.Windows.Forms.BindingSource companieBindingSource;
        private SeboDataSetTableAdapters.CompanieTableAdapter companieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numecompanieDataGridViewTextBoxColumn;
    }
}