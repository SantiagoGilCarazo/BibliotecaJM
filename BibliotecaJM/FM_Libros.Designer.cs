namespace BibliotecaJM
{
    partial class FM_Libros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label titulo_libLabel1;
            System.Windows.Forms.Label autor_libLabel1;
            System.Windows.Forms.Label id_libLabel1;
            System.Windows.Forms.Label prestado_sn_libLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.bBuscarAutor = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.prestado_sn_libLabel1 = new System.Windows.Forms.Label();
            this.id_libLabel2 = new System.Windows.Forms.Label();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel1 = new System.Windows.Forms.Label();
            autor_libLabel1 = new System.Windows.Forms.Label();
            id_libLabel1 = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(58, 48);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(68, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "Identificador:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(58, 74);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(33, 13);
            titulo_libLabel.TabIndex = 2;
            titulo_libLabel.Text = "Libro:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(58, 100);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 4;
            autor_libLabel.Text = "Autor:";
            // 
            // titulo_libLabel1
            // 
            titulo_libLabel1.AutoSize = true;
            titulo_libLabel1.Location = new System.Drawing.Point(97, 112);
            titulo_libLabel1.Name = "titulo_libLabel1";
            titulo_libLabel1.Size = new System.Drawing.Size(58, 13);
            titulo_libLabel1.TabIndex = 2;
            titulo_libLabel1.Text = "Titulo libro:";
            // 
            // autor_libLabel1
            // 
            autor_libLabel1.AutoSize = true;
            autor_libLabel1.Location = new System.Drawing.Point(97, 138);
            autor_libLabel1.Name = "autor_libLabel1";
            autor_libLabel1.Size = new System.Drawing.Size(57, 13);
            autor_libLabel1.TabIndex = 4;
            autor_libLabel1.Text = "Autor libro:";
            // 
            // id_libLabel1
            // 
            id_libLabel1.AutoSize = true;
            id_libLabel1.Location = new System.Drawing.Point(97, 74);
            id_libLabel1.Name = "id_libLabel1";
            id_libLabel1.Size = new System.Drawing.Size(16, 13);
            id_libLabel1.TabIndex = 5;
            id_libLabel1.Text = "Id";
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Location = new System.Drawing.Point(97, 178);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(52, 13);
            prestado_sn_libLabel.TabIndex = 6;
            prestado_sn_libLabel.Text = "Prestado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.bModificar);
            this.groupBox1.Controls.Add(this.bNuevo);
            this.groupBox1.Controls.Add(this.tbAutor);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Controls.Add(this.librosDataGridView);
            this.groupBox1.Controls.Add(this.bBuscarAutor);
            this.groupBox1.Controls.Add(this.bBuscarNombre);
            this.groupBox1.Controls.Add(this.bBuscarId);
            this.groupBox1.Controls.Add(id_libLabel);
            this.groupBox1.Controls.Add(titulo_libLabel);
            this.groupBox1.Controls.Add(autor_libLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 676);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(366, 615);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 11;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(221, 615);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 11;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(75, 615);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 11;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(132, 97);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(256, 20);
            this.tbAutor.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(132, 71);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(256, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(132, 45);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(256, 20);
            this.tbId.TabIndex = 10;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AllowUserToResizeColumns = false;
            this.librosDataGridView.AllowUserToResizeRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(6, 145);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(494, 440);
            this.librosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo libro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor libro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prestado libro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bBuscarAutor
            // 
            this.bBuscarAutor.Location = new System.Drawing.Point(411, 95);
            this.bBuscarAutor.Name = "bBuscarAutor";
            this.bBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.bBuscarAutor.TabIndex = 6;
            this.bBuscarAutor.Text = "Buscar";
            this.bBuscarAutor.UseVisualStyleBackColor = true;
            this.bBuscarAutor.Click += new System.EventHandler(this.bBuscarAutor_Click);
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(411, 69);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 6;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            this.bBuscarNombre.Click += new System.EventHandler(this.bBuscarNombre_Click);
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(411, 43);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 6;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            this.bBuscarId.Click += new System.EventHandler(this.bBuscarId_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCancelar);
            this.groupBox2.Controls.Add(this.bAceptar);
            this.groupBox2.Controls.Add(prestado_sn_libLabel);
            this.groupBox2.Controls.Add(this.prestado_sn_libLabel1);
            this.groupBox2.Controls.Add(id_libLabel1);
            this.groupBox2.Controls.Add(this.id_libLabel2);
            this.groupBox2.Controls.Add(titulo_libLabel1);
            this.groupBox2.Controls.Add(this.titulo_libTextBox);
            this.groupBox2.Controls.Add(autor_libLabel1);
            this.groupBox2.Controls.Add(this.autor_libTextBox);
            this.groupBox2.Location = new System.Drawing.Point(539, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 676);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(301, 615);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(203, 615);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 8;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // prestado_sn_libLabel1
            // 
            this.prestado_sn_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "prestado_sn_lib", true));
            this.prestado_sn_libLabel1.Location = new System.Drawing.Point(181, 178);
            this.prestado_sn_libLabel1.Name = "prestado_sn_libLabel1";
            this.prestado_sn_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.prestado_sn_libLabel1.TabIndex = 7;
            // 
            // id_libLabel2
            // 
            this.id_libLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libLabel2.Location = new System.Drawing.Point(178, 74);
            this.id_libLabel2.Name = "id_libLabel2";
            this.id_libLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_libLabel2.TabIndex = 6;
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(181, 109);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(246, 20);
            this.titulo_libTextBox.TabIndex = 3;
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(181, 135);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(246, 20);
            this.autor_libTextBox.TabIndex = 5;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button bBuscarAutor;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label prestado_sn_libLabel1;
        private System.Windows.Forms.Label id_libLabel2;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
    }
}
