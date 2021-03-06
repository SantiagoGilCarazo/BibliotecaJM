﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

       

        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);
            Busqueda();
        }

        private void Busqueda()
        {
            gbBusqueda.Enabled = true;
            gbEdicion.Enabled = false;
        }

        private void bBuscarId_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillById(dS_Lectores.lectores, int.Parse(tbID.Text));

        }

        private void bBuscarNombre_Click(object sender, EventArgs e)
        {
            this.lectoresTableAdapter.FillByNombre(dS_Lectores.lectores, tbNombre.Text);

        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            lectoresBindingSource.AddNew();
            Edicion();
        }

        private void Edicion()
        {
            gbEdicion.Enabled = true;
            gbBusqueda.Enabled = false;
            nombre_lecTextBox.Focus();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            Edicion();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Está seguro de que desea eliminarlo?", "Borrado", MessageBoxButtons.YesNo))
            {
                try
                {
                    lectoresBindingSource.RemoveCurrent();
                    lectoresTableAdapter.Update(dS_Lectores.lectores);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha podido eliminar el lector");
                }
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                this.lectoresTableAdapter.Update(dS_Lectores.lectores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir los datos"+ex.Message);
            }
            Busqueda();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void bLookUp_Click(object sender, EventArgs e)
        {
            FM_Provincia pro = new FM_Provincia();
            pro.ShowDialog();
            provincia_lecTextBox.Text = pro.idProvincia.ToString();
        }


    }
}
