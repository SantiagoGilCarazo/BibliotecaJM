namespace BibliotecaJM
{
    partial class FM_Provincia
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
            this.dS_Provincias = new BibliotecaJM.DS_Provincias();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provinciasTableAdapter = new BibliotecaJM.DS_ProvinciasTableAdapters.provinciasTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager();
            this.provinciasDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dS_Provincias
            // 
            this.dS_Provincias.DataSetName = "DS_Provincias";
            this.dS_Provincias.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "provincias";
            this.provinciasBindingSource.DataSource = this.dS_Provincias;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.provinciasTableAdapter = this.provinciasTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_ProvinciasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // provinciasDataGridView
            // 
            this.provinciasDataGridView.AllowUserToAddRows = false;
            this.provinciasDataGridView.AllowUserToDeleteRows = false;
            this.provinciasDataGridView.AllowUserToResizeColumns = false;
            this.provinciasDataGridView.AllowUserToResizeRows = false;
            this.provinciasDataGridView.AutoGenerateColumns = false;
            this.provinciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provinciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataGridViewTextBoxColumn2});
            this.provinciasDataGridView.DataSource = this.provinciasBindingSource;
            this.provinciasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.provinciasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.provinciasDataGridView.Name = "provinciasDataGridView";
            this.provinciasDataGridView.ReadOnly = true;
            this.provinciasDataGridView.RowHeadersVisible = false;
            this.provinciasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.provinciasDataGridView.Size = new System.Drawing.Size(205, 203);
            this.provinciasDataGridView.TabIndex = 1;
            this.provinciasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provinciasDataGridView_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_pro";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "provincia_pro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FM_Provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 203);
            this.Controls.Add(this.provinciasDataGridView);
            this.Name = "FM_Provincia";
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.FM_Provincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Provincias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_Provincias dS_Provincias;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private DS_ProvinciasTableAdapters.provinciasTableAdapter provinciasTableAdapter;
        private DS_ProvinciasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView provinciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}