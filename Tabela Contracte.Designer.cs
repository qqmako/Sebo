
namespace Sebo1
{
    partial class Tabela_Contracte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabela_Contracte));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcontractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idangajatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idofertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataimprumutuluiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seboDataSet5 = new Sebo1.SeboDataSet5();
            this.contractTableAdapter = new Sebo1.SeboDataSet5TableAdapters.ContractTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet5)).BeginInit();
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
            this.idcontractDataGridViewTextBoxColumn,
            this.idangajatDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.idofertaDataGridViewTextBoxColumn,
            this.dataimprumutuluiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcontractDataGridViewTextBoxColumn
            // 
            this.idcontractDataGridViewTextBoxColumn.DataPropertyName = "Id_contract";
            this.idcontractDataGridViewTextBoxColumn.HeaderText = "Id_contract";
            this.idcontractDataGridViewTextBoxColumn.Name = "idcontractDataGridViewTextBoxColumn";
            this.idcontractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idangajatDataGridViewTextBoxColumn
            // 
            this.idangajatDataGridViewTextBoxColumn.DataPropertyName = "Id_angajat";
            this.idangajatDataGridViewTextBoxColumn.HeaderText = "Id_angajat";
            this.idangajatDataGridViewTextBoxColumn.Name = "idangajatDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "Id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // idofertaDataGridViewTextBoxColumn
            // 
            this.idofertaDataGridViewTextBoxColumn.DataPropertyName = "Id_oferta";
            this.idofertaDataGridViewTextBoxColumn.HeaderText = "Id_oferta";
            this.idofertaDataGridViewTextBoxColumn.Name = "idofertaDataGridViewTextBoxColumn";
            // 
            // dataimprumutuluiDataGridViewTextBoxColumn
            // 
            this.dataimprumutuluiDataGridViewTextBoxColumn.DataPropertyName = "Data_imprumutului";
            this.dataimprumutuluiDataGridViewTextBoxColumn.HeaderText = "Data_imprumutului";
            this.dataimprumutuluiDataGridViewTextBoxColumn.Name = "dataimprumutuluiDataGridViewTextBoxColumn";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.seboDataSet5;
            // 
            // seboDataSet5
            // 
            this.seboDataSet5.DataSetName = "SeboDataSet5";
            this.seboDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // Tabela_Contracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 414);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabela_Contracte";
            this.Text = "Tabela_Contracte";
            this.Load += new System.EventHandler(this.Tabela_Contracte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seboDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SeboDataSet5 seboDataSet5;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private SeboDataSet5TableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idangajatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idofertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataimprumutuluiDataGridViewTextBoxColumn;
    }
}