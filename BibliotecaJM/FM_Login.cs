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
    public partial class FM_Login : Form
    {
        public FM_Login()
        {
            InitializeComponent();
            nombre_usuTextBox.Focus();

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string tipo = "";
            string nombre = nombre_usuTextBox.Text;
            string contraseña = password_usuTextBox.Text;
            int posicion = 0;
            if (!nombre.Equals("") && !contraseña.Equals(""))
            {

                if (usuariosTableAdapter.FillByUsuPass(dS_Usuarios.usuarios, nombre, contraseña) == 1)
                {
                    this.Visible = false;
                    posicion = usuariosBindingSource.Position;
                    tipo = dS_Usuarios.usuarios[posicion].tipo_usu;
                    FM_Principal fm = new FM_Principal(nombre, tipo);
                    fm.ShowDialog();
                    this.Close();
                }

                else
                    MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
                MessageBox.Show("Rellene todos los campos");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
