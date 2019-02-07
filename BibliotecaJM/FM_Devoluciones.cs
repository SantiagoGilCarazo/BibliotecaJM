using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Devoluciones : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Devoluciones()
        {
            InitializeComponent();
        }

        public FM_Devoluciones(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        

        
        

        private void bBuscarLibro_Click(object sender, EventArgs e)
        {
            int idLibro = int.Parse(tbLibro.Text);
            this.librosTableAdapter.FillById(dS_Libros.libros, idLibro);
        }

        private void bBuscarLector_Click(object sender, EventArgs e)
        {
            int idLector = int.Parse(tbLector.Text);
            this.lectoresTableAdapter.FillById(dS_Lectores.lectores, idLector);
            this.librosPrestadosTableAdapter.FillById(dS_LibrosPrestados.LibrosPrestados,idLector);
        }

        private void FM_Devoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Prestamos.prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.dS_Prestamos.prestamos);

        }
    }
}
