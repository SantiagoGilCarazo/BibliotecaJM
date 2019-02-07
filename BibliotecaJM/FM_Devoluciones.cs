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

            int posicion = librosPrestadosBindingSource.Position;
            int id = dS_LibrosPrestados.LibrosPrestados[posicion].id_lib - 1;


            if (e.ColumnIndex == 4 && id_lecLabel1.Text != "")
            {
                DS_Configuracion.configuracionDataTable configuracion = new DS_Configuracion.configuracionDataTable();
                DS_ConfiguracionTableAdapters.configuracionTableAdapter configTa = new DS_ConfiguracionTableAdapters.configuracionTableAdapter();
                configTa.Fill(configuracion);


                DS_Libros.librosDataTable libros = new DS_Libros.librosDataTable();
                DS_LibrosTableAdapters.librosTableAdapter librosTa = new DS_LibrosTableAdapters.librosTableAdapter();
                librosTa.Fill(libros);
                libros[id].prestado_sn_lib.Remove(0, libros[posicion].prestado_sn_lib.Length);
                libros[id].prestado_sn_lib = "N";
                librosBindingSource.EndEdit();
                librosTableAdapter.Update(libros);

                DS_Historico_prestamos.historico_prestamosDataTable historicoPrestamos = new DS_Historico_prestamos.historico_prestamosDataTable();
                DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter historicoTa = new DS_Historico_prestamosTableAdapters.historico_prestamosTableAdapter();
                DS_Historico_prestamos.historico_prestamosRow fila = historicoPrestamos.Newhistorico_prestamosRow();
                fila.fecha_devol_his = DateTime.Now;
                fila.fecha_presta_his = dS_LibrosPrestados.LibrosPrestados[posicion].fecha_presta_pre;
                fila.id_lec_his = int.Parse(id_lecLabel1.Text);
                fila.id_lib_his = dS_LibrosPrestados.LibrosPrestados[posicion].id_lib;
                historicoPrestamos.Addhistorico_prestamosRow(fila);
                historicoTa.Update(historicoPrestamos);


                DS_Prestamos.prestamosDataTable prestamos = new DS_Prestamos.prestamosDataTable();
                DS_PrestamosTableAdapters.prestamosTableAdapter prestamosTa = new DS_PrestamosTableAdapters.prestamosTableAdapter();
                prestamosTa.Fill(prestamos);

                prestamosTa.Delete(prestamos[id].id_lec_pre, prestamos[id].id_lib_pre, prestamos[id].fecha_devol_pre, prestamos[id].fecha_presta_pre);
                prestamosTa.Update(prestamos);


                if (DateTime.Now > dS_LibrosPrestados.LibrosPrestados[posicion].fecha_devol_pre)
                {
                    int numeroLectores = dS_Lectores.lectores.Count;
                    for (int i = 0; i < numeroLectores; i++)
                    {
                        if (i==dS_Lectores.lectores[i].id_lec)
                        {
                            DateTime fechaPenal = DateTime.Now.AddDays(DateTime.Now.DayOfYear - dS_LibrosPrestados.LibrosPrestados[posicion].fecha_devol_pre.DayOfYear);
                            if (fechaPenal.DayOfYear>configuracion[0].dias_penalizacion_cnf)
                            {
                                dS_Lectores.lectores[i].fecha_penalizacion_lec = DateTime.Now.AddDays(configuracion[0].dias_penalizacion_cnf);
                                lectoresBindingSource.EndEdit();
                                lectoresTableAdapter.Update(dS_Lectores.lectores);

                            }else
                            dS_Lectores.lectores[i].fecha_penalizacion_lec = DateTime.Now.AddDays(fechaPenal.DayOfYear);
                            lectoresBindingSource.EndEdit();
                            lectoresTableAdapter.Update(dS_Lectores.lectores);
                        }
                    }
                }


                this.librosPrestadosTableAdapter.FillById(dS_LibrosPrestados.LibrosPrestados, int.Parse(tbLector.Text));

                MessageBox.Show("Libro devuelto correctamente.");

            }else
                MessageBox.Show("Busque un lector.");
                id_lecLabel1.Focus();



        }
    }
}
