using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Libros : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Libros()
        {
            InitializeComponent();
        }

        public FM_Libros(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            
        }

       


        private void bBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                librosTableAdapter.FillById(dS_Libros.libros, int.Parse(tbId.Text));
            }
            catch (Exception)
            {

                MessageBox.Show("Introduzca un id correcto.");
            }
        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByNombreLib(dS_Libros.libros, tbNombre.Text);
        }

        private void bBuscarAutor_Click(object sender, EventArgs e)
        {
            librosTableAdapter.FillByAutor(dS_Libros.libros, tbAutor.Text);
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            librosBindingSource.AddNew();
            prestado_sn_libLabel1.Text = "N";
            edicion();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            edicion();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes== MessageBox.Show("¿Está seguro de que quiere eliminar este libro?","Eliminado.",MessageBoxButtons.YesNo))
            {
                try
                {
                    librosBindingSource.RemoveCurrent();
                    librosTableAdapter.Update(dS_Libros.libros);
                }
                catch (Exception)
                {

                    MessageBox.Show("No se ha podido eliminar el libro.");
                }
                
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                librosBindingSource.EndEdit();
                librosTableAdapter.Update(dS_Libros.libros);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al escribir los datos.");
            }
            
            busqueda();
            
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            busqueda();
            
        }

        private void busqueda()
        {
            groupBox1.Enabled=true;
            groupBox2.Enabled = false;
        }
        private void edicion()
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            id_libLabel2.Focus();
        }

        private void FM_Libros_Load(object sender, EventArgs e)
        {
            librosTableAdapter.Fill(dS_Libros.libros);
            busqueda();
        }

        
    }
}
