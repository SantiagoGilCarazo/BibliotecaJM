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
        public string Prestado { get; set; }
        public FM_Prestamos()
        {
            InitializeComponent();
        }

        public FM_Prestamos(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            int IdLec = int.Parse(tbIDLector.Text);
            this.lectoresTableAdapter.FillById(this.dS_Lectores.lectores, IdLec);
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
            //int idLector = int.Parse(id_lecLabel1.Text);
            DateTime fechaActual = DateTime.Today;
            //DateTime? fechaPenalizacion = dS_Lectores.lectores[0].fecha_penalizacion_lec;
            string fecha = fechaActual.ToShortDateString();
            int dias = dS_Configuracion.configuracion[0].dias_prestamo_cnf;
            Prestado = dS_Libros.libros[posicionLibros].prestado_sn_lib;
            

            if (Prestado.Contains("N") && librosPrestadosDataGridView.RowCount <= 5)
            {
                if (dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull() || dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Today)
                {

                    prestamosBindingSource.AddNew();
                    if (dS_Lectores.lectores[0].id_lec!=0)
                    {
                        dS_Prestamos.prestamos[0].id_lec_pre = dS_Lectores.lectores[0].id_lec;
                    }
                    
                    dS_Prestamos.prestamos[0].id_lib_pre = dS_Libros.libros[posicionLibros].id_lib;
                    dS_Prestamos.prestamos[0].fecha_presta_pre = DateTime.Today;
                    dS_Prestamos.prestamos[0].fecha_devol_pre = DateTime.Today.AddDays(dS_Configuracion.configuracion[0].dias_prestamo_cnf);
                    prestamosBindingSource.EndEdit();
                    prestamosTableAdapter.Update(dS_Prestamos.prestamos);
                    dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull().Equals(null);
                    Prestado = "S";
                    




                }
                else
                    MessageBox.Show("El usuario está penalizado y no puede realizar préstamos.");
            }
            else
            {
                MessageBox.Show("No se puede prestar el libro porque ya está prestado o la persona tiene 5 libros prestados.");
            }
        }
    }
}
