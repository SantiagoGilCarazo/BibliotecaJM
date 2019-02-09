using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Provincia : Form
    {
        public int idProvincia = 0;
        public FM_Provincia()
        {
            InitializeComponent();
        }

        private void FM_Provincia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void provinciasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = provinciasBindingSource.Position;
            idProvincia = dS_Provincias.provincias[posicion].id_pro;
            
            this.Close();
        }
    }
}
