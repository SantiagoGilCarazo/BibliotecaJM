namespace BibliotecaJM
{
    partial class FM_Login
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
            System.Windows.Forms.Label nombre_usuLabel;
            System.Windows.Forms.Label password_usuLabel;
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.dS_Usuarios = new BibliotecaJM.DS_Usuarios();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new BibliotecaJM.DS_UsuariosTableAdapters.usuariosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_UsuariosTableAdapters.TableAdapterManager();
            this.nombre_usuTextBox = new System.Windows.Forms.TextBox();
            this.password_usuTextBox = new System.Windows.Forms.TextBox();
            nombre_usuLabel = new System.Windows.Forms.Label();
            password_usuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_usuLabel
            // 
            nombre_usuLabel.AutoSize = true;
            nombre_usuLabel.Location = new System.Drawing.Point(54, 31);
            nombre_usuLabel.Name = "nombre_usuLabel";
            nombre_usuLabel.Size = new System.Drawing.Size(47, 13);
            nombre_usuLabel.TabIndex = 5;
            nombre_usuLabel.Text = "Nombre:";
            // 
            // password_usuLabel
            // 
            password_usuLabel.AutoSize = true;
            password_usuLabel.Location = new System.Drawing.Point(54, 69);
            password_usuLabel.Name = "password_usuLabel";
            password_usuLabel.Size = new System.Drawing.Size(61, 13);
            password_usuLabel.TabIndex = 6;
            password_usuLabel.Text = "Contraseña";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(174, 109);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(50, 109);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // dS_Usuarios
            // 
            this.dS_Usuarios.DataSetName = "DS_Usuarios";
            this.dS_Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.dS_Usuarios;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_UsuariosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // nombre_usuTextBox
            // 
            this.nombre_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nombre_usu", true));
            this.nombre_usuTextBox.Location = new System.Drawing.Point(135, 28);
            this.nombre_usuTextBox.Name = "nombre_usuTextBox";
            this.nombre_usuTextBox.Size = new System.Drawing.Size(114, 20);
            this.nombre_usuTextBox.TabIndex = 6;
            // 
            // password_usuTextBox
            // 
            this.password_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "password_usu", true));
            this.password_usuTextBox.Location = new System.Drawing.Point(135, 66);
            this.password_usuTextBox.Name = "password_usuTextBox";
            this.password_usuTextBox.PasswordChar = '*';
            this.password_usuTextBox.Size = new System.Drawing.Size(114, 20);
            this.password_usuTextBox.TabIndex = 7;
            // 
            // FM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 155);
            this.Controls.Add(password_usuLabel);
            this.Controls.Add(this.password_usuTextBox);
            this.Controls.Add(nombre_usuLabel);
            this.Controls.Add(this.nombre_usuTextBox);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Name = "FM_Login";
            this.Text = "Identificación";
            ((System.ComponentModel.ISupportInitialize)(this.dS_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private DS_Usuarios dS_Usuarios;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DS_UsuariosTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private DS_UsuariosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_usuTextBox;
        private System.Windows.Forms.TextBox password_usuTextBox;
    }
}