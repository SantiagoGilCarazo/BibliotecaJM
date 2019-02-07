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
            try
            {
                int IdLec = int.Parse(tbIDLector.Text);
                this.lectoresTableAdapter.FillById(this.dS_Lectores.lectores, IdLec);
                this.librosPrestadosTableAdapter.FillByIdLector(this.dS_LibrosPrestados.LibrosPrestados, IdLec);
            }
            catch (Exception)
            {
                MessageBox.Show("Introduce un id.");
                tbIDLector.Focus();
            }
            

        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreLec = tbNombre.Text;
                this.lectoresTableAdapter.FillByNombreCompleto(this.dS_Lectores.lectores, nombreLec);
                this.librosPrestadosTableAdapter.FillByNombre(this.dS_LibrosPrestados.LibrosPrestados, nombreLec);
            }
            catch (Exception)
            {

                MessageBox.Show("Introduce un nombre.");
                tbNombre.Focus();
            }        

        }

        private void bIdentificador_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbIdentificador.Text);
                this.librosTableAdapter.FillById(dS_Libros.libros, id);
            }
            catch (Exception)
            {

                MessageBox.Show("Introduce un id.");
                tbIdentificador.Focus();
            }

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
            //int dias = dS_Configuracion.configuracion[0].dias_prestamo_cnf;
            Prestado = dS_Libros.libros[posicionLibros].prestado_sn_lib;

            if (id_lecLabel1.Text != "")
            {
                if (Prestado.Contains("N") && librosPrestadosDataGridView.RowCount <= 5)
                {
                    if (dS_Lectores.lectores[0].Isfecha_penalizacion_lecNull() || dS_Lectores.lectores[0].fecha_penalizacion_lec < DateTime.Today)
                    {
                        DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
                        DS_ConfiguracionTableAdapters.configuracionTableAdapter configuracionTa = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();
                        configuracionTa.Fill(configuracion);

                        int diasPrestamo = configuracion[0].dias_prestamo_cnf;
                        DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
                        DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTa = new DS_PrestamosTableAdapters.prestamosTableAdapter();
                        DS_Prestamos.prestamosRow fila = prestamos.NewprestamosRow();
                        fila.id_lec_pre = dS_Lectores.lectores[0].id_lec;
                        fila.id_lib_pre = dS_Libros.libros[posicionLibros].id_lib;
                        fila.fecha_presta_pre = DateTime.Now;
                        fila.fecha_devol_pre = DateTime.Now.AddDays(configuracion[0].dias_prestamo_cnf);

                        prestamos.AddprestamosRow(fila);
                        prestamosTa.Update(prestamos);


                        dS_Libros.libros[posicionLibros].prestado_sn_lib.Remove(0, dS_Libros.libros[posicionLibros].prestado_sn_lib.Length);
                        dS_Libros.libros[posicionLibros].prestado_sn_lib = "S";
                        librosBindingSource.EndEdit();
                        librosTableAdapter.Update(dS_Libros.libros);
                        librosDataGridView.Update();


                        //string fechaPenalizacion = dS_Lectores.lectores[0].fecha_penalizacion_lec.ToString();
                        //fechaPenalizacion = "";                   
                        //lectoresBindingSource.EndEdit();
                        //lectoresTableAdapter.Update(dS_Lectores.lectores);
                        //lectoresTableAdapter.FillById(dS_Lectores.lectores,int.Parse(tbIDLector.Text));

                        librosPrestadosTableAdapter.FillByIdLector(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbIDLector.Text));

                        MessageBox.Show("El préstamo se ha realizado correctamente.");

                    }
                    else
                        MessageBox.Show("El usuario está penalizado y no puede realizar préstamos.");
                }
                else
                {
                    MessageBox.Show("No se puede prestar el libro porque ya está prestado o la persona tiene 5 libros prestados.");
                }
            }
            else
                MessageBox.Show("Debes buscar primero un lector.");


        }

        private void FM_Prestamos_Load(object sender, EventArgs e)
        {
            this.librosTableAdapter.Fill(this.dS_Libros.libros);
        }
    }
}
