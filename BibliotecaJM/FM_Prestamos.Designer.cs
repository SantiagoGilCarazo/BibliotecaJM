namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.bNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIDLector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bPrestamo = new System.Windows.Forms.Button();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.bAutor = new System.Windows.Forms.Button();
            this.bTitulo = new System.Windows.Forms.Button();
            this.bIdentificador = new System.Windows.Forms.Button();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdentificador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager2 = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(55, 111);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(54, 13);
            id_lecLabel.TabIndex = 6;
            id_lecLabel.Text = "ID Lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(55, 134);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 8;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(55, 157);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 10;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(55, 185);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(103, 13);
            fecha_penalizacion_lecLabel.TabIndex = 18;
            fecha_penalizacion_lecLabel.Text = "Fecha Penalización:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_lecLabel);
            this.groupBox1.Controls.Add(this.id_lecLabel1);
            this.groupBox1.Controls.Add(nombre_lecLabel);
            this.groupBox1.Controls.Add(this.nombre_lecLabel1);
            this.groupBox1.Controls.Add(domicilio_lecLabel);
            this.groupBox1.Controls.Add(this.domicilio_lecLabel1);
            this.groupBox1.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox1.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.groupBox1.Controls.Add(this.bNombre);
            this.groupBox1.Controls.Add(this.bBuscarId);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.tbIDLector);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Lector";
            // 
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(177, 111);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel1.TabIndex = 7;
            this.id_lecLabel1.Text = "label3";
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(177, 134);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel1.TabIndex = 9;
            this.nombre_lecLabel1.Text = "label3";
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(177, 157);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.domicilio_lecLabel1.TabIndex = 11;
            this.domicilio_lecLabel1.Text = "label3";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(177, 185);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 19;
            this.fecha_penalizacion_lecLabel1.Text = "label3";
            // 
            // bNombre
            // 
            this.bNombre.Location = new System.Drawing.Point(344, 59);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(75, 23);
            this.bNombre.TabIndex = 2;
            this.bNombre.Text = "Buscar";
            this.bNombre.UseVisualStyleBackColor = true;
            this.bNombre.Click += new System.EventHandler(this.bNombre_Click);
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(344, 29);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 2;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            this.bBuscarId.Click += new System.EventHandler(this.bBuscarId_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(108, 59);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(213, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbIDLector
            // 
            this.tbIDLector.Location = new System.Drawing.Point(108, 32);
            this.tbIDLector.Name = "tbIDLector";
            this.tbIDLector.Size = new System.Drawing.Size(213, 20);
            this.tbIDLector.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Lector:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bPrestamo);
            this.groupBox2.Controls.Add(this.librosDataGridView);
            this.groupBox2.Controls.Add(this.bAutor);
            this.groupBox2.Controls.Add(this.bTitulo);
            this.groupBox2.Controls.Add(this.bIdentificador);
            this.groupBox2.Controls.Add(this.tbAutor);
            this.groupBox2.Controls.Add(this.tbTitulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbIdentificador);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 676);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Libro";
            // 
            // bPrestamo
            // 
            this.bPrestamo.Location = new System.Drawing.Point(32, 630);
            this.bPrestamo.Name = "bPrestamo";
            this.bPrestamo.Size = new System.Drawing.Size(421, 23);
            this.bPrestamo.TabIndex = 10;
            this.bPrestamo.Text = "REALIZAR PRÉSTAMO";
            this.bPrestamo.UseVisualStyleBackColor = true;
            this.bPrestamo.Click += new System.EventHandler(this.bPrestamo_Click);
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(32, 175);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.RowHeadersVisible = false;
            this.librosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosDataGridView.Size = new System.Drawing.Size(421, 437);
            this.librosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prestado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            // bAutor
            // 
            this.bAutor.Location = new System.Drawing.Point(340, 118);
            this.bAutor.Name = "bAutor";
            this.bAutor.Size = new System.Drawing.Size(75, 23);
            this.bAutor.TabIndex = 7;
            this.bAutor.Text = "Buscar";
            this.bAutor.UseVisualStyleBackColor = true;
            this.bAutor.Click += new System.EventHandler(this.bAutor_Click);
            // 
            // bTitulo
            // 
            this.bTitulo.Location = new System.Drawing.Point(340, 73);
            this.bTitulo.Name = "bTitulo";
            this.bTitulo.Size = new System.Drawing.Size(75, 23);
            this.bTitulo.TabIndex = 7;
            this.bTitulo.Text = "Buscar";
            this.bTitulo.UseVisualStyleBackColor = true;
            this.bTitulo.Click += new System.EventHandler(this.bTitulo_Click);
            // 
            // bIdentificador
            // 
            this.bIdentificador.Location = new System.Drawing.Point(340, 32);
            this.bIdentificador.Name = "bIdentificador";
            this.bIdentificador.Size = new System.Drawing.Size(75, 23);
            this.bIdentificador.TabIndex = 8;
            this.bIdentificador.Text = "Buscar";
            this.bIdentificador.UseVisualStyleBackColor = true;
            this.bIdentificador.Click += new System.EventHandler(this.bIdentificador_Click);
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(104, 118);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(213, 20);
            this.tbAutor.TabIndex = 5;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(104, 73);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(213, 20);
            this.tbTitulo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Autor:";
            // 
            // tbIdentificador
            // 
            this.tbIdentificador.Location = new System.Drawing.Point(104, 35);
            this.tbIdentificador.Name = "tbIdentificador";
            this.tbIdentificador.Size = new System.Drawing.Size(213, 20);
            this.tbIdentificador.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Titulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Identificador:";
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AllowUserToResizeColumns = false;
            this.librosPrestadosDataGridView.AllowUserToResizeRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(12, 254);
            this.librosPrestadosDataGridView.MultiSelect = false;
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(454, 352);
            this.librosPrestadosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager2.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1018, 708);
            this.Controls.Add(this.librosPrestadosDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIDLector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button bAutor;
        private System.Windows.Forms.Button bTitulo;
        private System.Windows.Forms.Button bIdentificador;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdentificador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Button bPrestamo;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
