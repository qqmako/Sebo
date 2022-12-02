
namespace Sebo1
{
    partial class Tabela_Oferte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela_Oferte));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idofertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaimprumutuluiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termenulcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratalunaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oferteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet2 = new Sebo1.SeboDataSet2();
            this.oferteTableAdapter = new Sebo1.SeboDataSet2TableAdapters.OferteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idofertaDataGridViewTextBoxColumn,
            this.sumaimprumutuluiDataGridViewTextBoxColumn,
            this.termenulcreditDataGridViewTextBoxColumn,
            this.ratalunaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oferteBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // idofertaDataGridViewTextBoxColumn
            // 
            this.idofertaDataGridViewTextBoxColumn.DataPropertyName = "Id_oferta";
            this.idofertaDataGridViewTextBoxColumn.HeaderText = "Id_oferta";
            this.idofertaDataGridViewTextBoxColumn.Name = "idofertaDataGridViewTextBoxColumn";
            this.idofertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumaimprumutuluiDataGridViewTextBoxColumn
            // 
            this.sumaimprumutuluiDataGridViewTextBoxColumn.DataPropertyName = "Suma_imprumutului";
            this.sumaimprumutuluiDataGridViewTextBoxColumn.HeaderText = "Suma_imprumutului";
            this.sumaimprumutuluiDataGridViewTextBoxColumn.Name = "sumaimprumutuluiDataGridViewTextBoxColumn";
            // 
            // termenulcreditDataGridViewTextBoxColumn
            // 
            this.termenulcreditDataGridViewTextBoxColumn.DataPropertyName = "Termenul_credit";
            this.termenulcreditDataGridViewTextBoxColumn.HeaderText = "Termenul_credit";
            this.termenulcreditDataGridViewTextBoxColumn.Name = "termenulcreditDataGridViewTextBoxColumn";
            // 
            // ratalunaraDataGridViewTextBoxColumn
            // 
            this.ratalunaraDataGridViewTextBoxColumn.DataPropertyName = "Rata_lunara";
            this.ratalunaraDataGridViewTextBoxColumn.HeaderText = "Rata_lunara";
            this.ratalunaraDataGridViewTextBoxColumn.Name = "ratalunaraDataGridViewTextBoxColumn";
            // 
            // oferteBindingSource
            // 
            this.oferteBindingSource.DataMember = "Oferte";
            this.oferteBindingSource.DataSource = this.seboDataSet2;
            // 
            // seboDataSet2
            // 
            this.seboDataSet2.DataSetName = "SeboDataSet2";
            this.seboDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oferteTableAdapter
            // 
            this.oferteTableAdapter.ClearBeforeFill = true;
            // 
            // Tabela_Oferte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabela_Oferte";
            this.Text = "Tabela_Oferte";
            this.Load += new System.EventHandler(this.Tabela_Oferte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oferteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SeboDataSet2 seboDataSet2;
        private System.Windows.Forms.BindingSource oferteBindingSource;
        private SeboDataSet2TableAdapters.OferteTableAdapter oferteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idofertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaimprumutuluiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termenulcreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratalunaraDataGridViewTextBoxColumn;
    }
}