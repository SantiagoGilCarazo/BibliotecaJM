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
            try
            {
                int idLibro = int.Parse(tbLibro.Text);
                this.librosPrestadosTableAdapter.FillByIdLibro(dS_LibrosPrestados.LibrosPrestados, idLibro);
            }
            catch (Exception)
            {

                MessageBox.Show("Introduce un id válido.");
                tbLibro.Focus();
            }
            
        }

        private void bBuscarLector_Click(object sender, EventArgs e)
        {
            try
            {
                int idLector = int.Parse(tbLector.Text);
                this.lectoresTableAdapter.FillById(dS_Lectores.lectores, idLector);
                this.librosPrestadosTableAdapter.FillById(dS_LibrosPrestados.LibrosPrestados, idLector);
            }
            catch (Exception)
            {

                MessageBox.Show("Introduce un id válido.");
                tbLector.Focus();
            }
            
        }

        private void FM_Devoluciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Prestamos.prestamos' Puede moverla o quitarla según sea necesario.
            this.prestamosTableAdapter.Fill(this.dS_Prestamos.prestamos);

        }

        private void librosPrestadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                MessageBox.Show("Has pulsado el botón.");
            }
        }
    }
}
