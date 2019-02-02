namespace BibliotecaJM
{
    partial class FM_Lectores
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
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            System.Windows.Forms.Label id_lecLabel1;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label provincia_lecLabel;
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.fecha_penalizacion_lecLabel1 = new System.Windows.Forms.Label();
            this.id_lecLabel2 = new System.Windows.Forms.Label();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.provincia_lecTextBox = new System.Windows.Forms.TextBox();
            this.bLookUp = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            id_lecLabel1 = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            this.gbEdicion.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbEdicion.Controls.Add(this.fecha_penalizacion_lecLabel1);
            this.gbEdicion.Controls.Add(id_lecLabel1);
            this.gbEdicion.Controls.Add(this.id_lecLabel2);
            this.gbEdicion.Controls.Add(nombre_lecLabel);
            this.gbEdicion.Controls.Add(this.nombre_lecTextBox);
            this.gbEdicion.Controls.Add(domicilio_lecLabel);
            this.gbEdicion.Controls.Add(this.domicilio_lecTextBox);
            this.gbEdicion.Controls.Add(provincia_lecLabel);
            this.gbEdicion.Controls.Add(this.provincia_lecTextBox);
            this.gbEdicion.Controls.Add(this.bLookUp);
            this.gbEdicion.Controls.Add(this.bCancelar);
            this.gbEdicion.Controls.Add(this.bAceptar);
            this.gbEdicion.Location = new System.Drawing.Point(512, 20);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Size = new System.Drawing.Size(486, 662);
            this.gbEdicion.TabIndex = 7;
            this.gbEdicion.TabStop = false;
            this.gbEdicion.Text = "Edicion de lector";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(83, 232);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(100, 13);
            fecha_penalizacion_lecLabel.TabIndex = 24;
            fecha_penalizacion_lecLabel.Text = "Fecha penalizacón:";
            // 
            // fecha_penalizacion_lecLabel1
            // 
            this.fecha_penalizacion_lecLabel1.Location = new System.Drawing.Point(205, 232);
            this.fecha_penalizacion_lecLabel1.Name = "fecha_penalizacion_lecLabel1";
            this.fecha_penalizacion_lecLabel1.Size = new System.Drawing.Size(100, 23);
            this.fecha_penalizacion_lecLabel1.TabIndex = 25;
            this.fecha_penalizacion_lecLabel1.Text = "label3";
            // 
            // id_lecLabel1
            // 
            id_lecLabel1.AutoSize = true;
            id_lecLabel1.Location = new System.Drawing.Point(83, 104);
            id_lecLabel1.Name = "id_lecLabel1";
            id_lecLabel1.Size = new System.Drawing.Size(19, 13);
            id_lecLabel1.TabIndex = 23;
            id_lecLabel1.Text = "Id:";
            // 
            // id_lecLabel2
            // 
            this.id_lecLabel2.Location = new System.Drawing.Point(201, 104);
            this.id_lecLabel2.Name = "id_lecLabel2";
            this.id_lecLabel2.Size = new System.Drawing.Size(100, 23);
            this.id_lecLabel2.TabIndex = 24;
            this.id_lecLabel2.Text = "label3";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(82, 142);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(47, 13);
            nombre_lecLabel.TabIndex = 17;
            nombre_lecLabel.Text = "Nombre:";
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.Location = new System.Drawing.Point(204, 139);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 18;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(82, 168);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(52, 13);
            domicilio_lecLabel.TabIndex = 19;
            domicilio_lecLabel.Text = "Domicilio:";
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(204, 165);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 20;
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(82, 194);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(54, 13);
            provincia_lecLabel.TabIndex = 21;
            provincia_lecLabel.Text = "Provincia:";
            // 
            // provincia_lecTextBox
            // 
            this.provincia_lecTextBox.Location = new System.Drawing.Point(204, 191);
            this.provincia_lecTextBox.Name = "provincia_lecTextBox";
            this.provincia_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.provincia_lecTextBox.TabIndex = 22;
            // 
            // bLookUp
            // 
            this.bLookUp.Location = new System.Drawing.Point(421, 191);
            this.bLookUp.Name = "bLookUp";
            this.bLookUp.Size = new System.Drawing.Size(30, 23);
            this.bLookUp.TabIndex = 15;
            this.bLookUp.Text = "...";
            this.bLookUp.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(329, 385);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(85, 385);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.lectoresDataGridView);
            this.gbBusqueda.Controls.Add(this.label2);
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.bEliminar);
            this.gbBusqueda.Controls.Add(this.bModificar);
            this.gbBusqueda.Controls.Add(this.bNuevo);
            this.gbBusqueda.Controls.Add(this.bBuscarNombre);
            this.gbBusqueda.Controls.Add(this.bBuscarId);
            this.gbBusqueda.Controls.Add(this.tbNombre);
            this.gbBusqueda.Controls.Add(this.tbID);
            this.gbBusqueda.Location = new System.Drawing.Point(12, 19);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(481, 663);
            this.gbBusqueda.TabIndex = 6;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de lector";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AllowUserToAddRows = false;
            this.lectoresDataGridView.AllowUserToDeleteRows = false;
            this.lectoresDataGridView.AllowUserToResizeColumns = false;
            this.lectoresDataGridView.AllowUserToResizeRows = false;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Location = new System.Drawing.Point(6, 142);
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.ReadOnly = true;
            this.lectoresDataGridView.RowHeadersVisible = false;
            this.lectoresDataGridView.Size = new System.Drawing.Size(469, 430);
            this.lectoresDataGridView.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(368, 578);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 3;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bModificar
            // 
            this.bModificar.Location = new System.Drawing.Point(204, 578);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(75, 23);
            this.bModificar.TabIndex = 3;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(37, 578);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 3;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(368, 68);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 3;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(368, 18);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 3;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(87, 70);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(262, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(85, 20);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(264, 20);
            this.tbID.TabIndex = 2;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1010, 700);
            this.Controls.Add(this.gbEdicion);
            this.Controls.Add(this.gbBusqueda);
            this.Name = "FM_Lectores";
            this.gbEdicion.ResumeLayout(false);
            this.gbEdicion.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.Label fecha_penalizacion_lecLabel1;
        private System.Windows.Forms.Label id_lecLabel2;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox provincia_lecTextBox;
        private System.Windows.Forms.Button bLookUp;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbID;
    }
}
