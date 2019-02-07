namespace BibliotecaJM
{
    partial class FM_Devoluciones
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
            System.Windows.Forms.Label id_libLabel1;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label id_lecLabel2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bBuscarLibro = new System.Windows.Forms.Button();
            this.id_libLabel2 = new System.Windows.Forms.Label();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.titulo_libLabel1 = new System.Windows.Forms.Label();
            this.autor_libLabel1 = new System.Windows.Forms.Label();
            this.tbLibro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bBuscarLector = new System.Windows.Forms.Button();
            this.tbLector = new System.Windows.Forms.TextBox();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.id_lecLabel1 = new System.Windows.Forms.Label();
            this.nombre_lecLabel1 = new System.Windows.Forms.Label();
            this.domicilio_lecLabel1 = new System.Windows.Forms.Label();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_LibrosPrestados = new BibliotecaJM.DS_LibrosPrestados();
            this.librosPrestadosTableAdapter = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.tableAdapterManager2 = new BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager();
            this.dS_Prestamos = new BibliotecaJM.DS_Prestamos();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosTableAdapter = new BibliotecaJM.DS_PrestamosTableAdapters.prestamosTableAdapter();
            this.tableAdapterManager3 = new BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager();
            id_libLabel = new System.Windows.Forms.Label();
            id_libLabel1 = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            id_lecLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(44, 35);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(58, 13);
            id_libLabel.TabIndex = 0;
            id_libLabel.Text = "Id del libro:";
            // 
            // id_libLabel1
            // 
            id_libLabel1.AutoSize = true;
            id_libLabel1.Location = new System.Drawing.Point(44, 91);
            id_libLabel1.Name = "id_libLabel1";
            id_libLabel1.Size = new System.Drawing.Size(41, 13);
            id_libLabel1.TabIndex = 2;
            id_libLabel1.Text = "Id libro:";
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(44, 114);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(36, 13);
            titulo_libLabel.TabIndex = 4;
            titulo_libLabel.Text = "Titulo:";
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(44, 137);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(35, 13);
            autor_libLabel.TabIndex = 6;
            autor_libLabel.Text = "Autor:";
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(23, 68);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(48, 13);
            id_lecLabel.TabIndex = 0;
            id_lecLabel.Text = "Id lector:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(23, 91);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 2;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(23, 114);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 4;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(23, 150);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(117, 13);
            fecha_penalizacion_lecLabel.TabIndex = 12;
            fecha_penalizacion_lecLabel.Text = "Fecha de penalización:";
            // 
            // id_lecLabel2
            // 
            id_lecLabel2.AutoSize = true;
            id_lecLabel2.Location = new System.Drawing.Point(26, 37);
            id_lecLabel2.Name = "id_lecLabel2";
            id_lecLabel2.Size = new System.Drawing.Size(48, 13);
            id_lecLabel2.TabIndex = 13;
            id_lecLabel2.Text = "Id lector:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bBuscarLibro);
            this.groupBox1.Controls.Add(id_libLabel1);
            this.groupBox1.Controls.Add(this.id_libLabel2);
            this.groupBox1.Controls.Add(titulo_libLabel);
            this.groupBox1.Controls.Add(this.titulo_libLabel1);
            this.groupBox1.Controls.Add(autor_libLabel);
            this.groupBox1.Controls.Add(this.autor_libLabel1);
            this.groupBox1.Controls.Add(id_libLabel);
            this.groupBox1.Controls.Add(this.tbLibro);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de libro";
            // 
            // bBuscarLibro
            // 
            this.bBuscarLibro.Location = new System.Drawing.Point(378, 31);
            this.bBuscarLibro.Name = "bBuscarLibro";
            this.bBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLibro.TabIndex = 8;
            this.bBuscarLibro.Text = "Buscar";
            this.bBuscarLibro.UseVisualStyleBackColor = true;
            this.bBuscarLibro.Click += new System.EventHandler(this.bBuscarLibro_Click);
            // 
            // id_libLabel2
            // 
            this.id_libLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libLabel2.Location = new System.Drawing.Point(128, 91);
            this.id_libLabel2.Name = "id_libLabel2";
            this.id_libLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_libLabel2.TabIndex = 3;
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
            // titulo_libLabel1
            // 
            this.titulo_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libLabel1.Location = new System.Drawing.Point(128, 114);
            this.titulo_libLabel1.Name = "titulo_libLabel1";
            this.titulo_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.titulo_libLabel1.TabIndex = 5;
            // 
            // autor_libLabel1
            // 
            this.autor_libLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libLabel1.Location = new System.Drawing.Point(128, 137);
            this.autor_libLabel1.Name = "autor_libLabel1";
            this.autor_libLabel1.Size = new System.Drawing.Size(100, 23);
            this.autor_libLabel1.TabIndex = 7;
            // 
            // tbLibro
            // 
            this.tbLibro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.tbLibro.Location = new System.Drawing.Point(128, 32);
            this.tbLibro.Name = "tbLibro";
            this.tbLibro.Size = new System.Drawing.Size(232, 20);
            this.tbLibro.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bBuscarLector);
            this.groupBox2.Controls.Add(id_lecLabel2);
            this.groupBox2.Controls.Add(this.tbLector);
            this.groupBox2.Controls.Add(id_lecLabel);
            this.groupBox2.Controls.Add(this.id_lecLabel1);
            this.groupBox2.Controls.Add(nombre_lecLabel);
            this.groupBox2.Controls.Add(this.nombre_lecLabel1);
            this.groupBox2.Controls.Add(domicilio_lecLabel);
            this.groupBox2.Controls.Add(this.domicilio_lecLabel1);
            this.groupBox2.Controls.Add(fecha_penalizacion_lecLabel);
            this.groupBox2.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.groupBox2.Location = new System.Drawing.Point(517, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 207);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda del lector";
            // 
            // bBuscarLector
            // 
            this.bBuscarLector.Location = new System.Drawing.Point(395, 32);
            this.bBuscarLector.Name = "bBuscarLector";
            this.bBuscarLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarLector.TabIndex = 15;
            this.bBuscarLector.Text = "Buscar";
            this.bBuscarLector.UseVisualStyleBackColor = true;
            this.bBuscarLector.Click += new System.EventHandler(this.bBuscarLector_Click);
            // 
            // tbLector
            // 
            this.tbLector.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.tbLector.Location = new System.Drawing.Point(89, 33);
            this.tbLector.Name = "tbLector";
            this.tbLector.Size = new System.Drawing.Size(291, 20);
            this.tbLector.TabIndex = 14;
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
            // id_lecLabel1
            // 
            this.id_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecLabel1.Location = new System.Drawing.Point(145, 68);
            this.id_lecLabel1.Name = "id_lecLabel1";
            this.id_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.id_lecLabel1.TabIndex = 1;
            // 
            // nombre_lecLabel1
            // 
            this.nombre_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecLabel1.Location = new System.Drawing.Point(145, 91);
            this.nombre_lecLabel1.Name = "nombre_lecLabel1";
            this.nombre_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.nombre_lecLabel1.TabIndex = 3;
            // 
            // domicilio_lecLabel1
            // 
            this.domicilio_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecLabel1.Location = new System.Drawing.Point(145, 114);
            this.domicilio_lecLabel1.Name = "domicilio_lecLabel1";
            this.domicilio_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.domicilio_lecLabel1.TabIndex = 5;
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(145, 150);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(200, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 13;
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
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.librosPrestadosDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1054, 429);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Libros prestados";
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
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(6, 19);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.RowHeadersVisible = false;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(1042, 404);
            this.librosPrestadosDataGridView.TabIndex = 0;
            this.librosPrestadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.librosPrestadosDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de préstamo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha de devolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Realizar devolución";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 150;
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.dS_LibrosPrestados;
            // 
            // dS_LibrosPrestados
            // 
            this.dS_LibrosPrestados.DataSetName = "DS_LibrosPrestados";
            this.dS_LibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = BibliotecaJM.DS_LibrosPrestadosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_Prestamos
            // 
            this.dS_Prestamos.DataSetName = "DS_Prestamos";
            this.dS_Prestamos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "prestamos";
            this.prestamosBindingSource.DataSource = this.dS_Prestamos;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.prestamosTableAdapter = this.prestamosTableAdapter;
            this.tableAdapterManager3.UpdateOrder = BibliotecaJM.DS_PrestamosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FM_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FM_Devoluciones";
            this.Load += new System.EventHandler(this.FM_Devoluciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_LibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Prestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bBuscarLibro;
        private System.Windows.Forms.Label id_libLabel2;
        private System.Windows.Forms.Label titulo_libLabel1;
        private System.Windows.Forms.Label autor_libLabel1;
        private System.Windows.Forms.TextBox tbLibro;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button bBuscarLector;
        private System.Windows.Forms.TextBox tbLector;
        private System.Windows.Forms.Label id_lecLabel1;
        private System.Windows.Forms.Label nombre_lecLabel1;
        private System.Windows.Forms.Label domicilio_lecLabel1;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DS_LibrosPrestados dS_LibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private DS_LibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private DS_LibrosPrestadosTableAdapters.TableAdapterManager tableAdapterManager2;
        private DS_Prestamos dS_Prestamos;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTableAdapter;
        private DS_PrestamosTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
