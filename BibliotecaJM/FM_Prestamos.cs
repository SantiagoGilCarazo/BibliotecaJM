using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Prestamos : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Libros.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
            
         

        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            int IdLec = int.Parse(tbIDLector.Text);           
            this.lectoresTableAdapter.FillById(this.dS_Lectores.lectores,IdLec);
            this.librosPrestadosTableAdapter.FillById(this.dS_LibrosPrestados.LibrosPrestados, IdLec);
            
        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            string nombreLec = tbNombre.Text;
            this.lectoresTableAdapter.FillByNombreCompleto(this.dS_Lectores.lectores, nombreLec);
            this.librosPrestadosTableAdapter.FillByNombre(this.dS_LibrosPrestados.LibrosPrestados, nombreLec);
        }

        private void bIdentificador_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbIdentificador.Text);
            this.librosTableAdapter.FillById(dS_Libros.libros, id);
        }

        private void bTitulo_Click(object sender, EventArgs e)
        {
            string titulo = tbTitulo.Text;
            this.librosTableAdapter.FillByNombreLib(this.dS_Libros.libros, titulo);
        }

        private void bAutor_Click(object sender, EventArgs e)
        {
            string autor = tbAutor.Text;
            this.librosTableAdapter.FillByAutor(this.dS_Libros.libros, autor);
        }

        private void bPrestamo_Click(object sender, EventArgs e)
        {            
            int posicionLibros = librosBindingSource.Position;
            int idLector = int.Parse(id_lecLabel1.Text);
            
            if (dS_Libros.libros[posicionLibros].prestado_sn_lib.ToLower().Equals("n") && 
                librosPrestadosDataGridView.RowCount<=5)
            {
                MessageBox.Show(librosPrestadosDataGridView.RowCount.ToString());
            }
            else
                MessageBox.Show("El libro ya está prestado o la persona tiene 5 o más libros prestados.");
        }
    }
}
