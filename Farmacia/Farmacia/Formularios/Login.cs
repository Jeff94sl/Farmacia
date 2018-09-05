using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Farmacia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void Validar()
        {
            Conexion Us = new Conexion();
            if (Us.getUsuario(UsersTxt.Text, PassTxt.Text))
            {
                MainForm Main = new MainForm();
                this.Hide();
                Main.Usuario.Text = Us.Id_Usuario + " " + Us.Usuarios;

                if (Us.Tipo_Users == true)
                {
                    Us = null;
                    Main.Show();
                }
                else
                {
                    Main.almacenToolStripMenuItem.Enabled = false;
                    Main.personalToolStripMenuItem.Enabled = false;
                    Us = null;
                    Main.Show();
                }
            }
            else
            {
                MessageBox.Show("Error Verifique su Usuario y Contraseña");
            }
        }
        void EntrarClick(object sender, EventArgs e)
        {
            Validar();
        }

        void LoginLoad(object sender, EventArgs e)
        {
            Conexion Us = new Conexion();
            List<string> Nombres = new List<string>();

            Us.Cargar_Usuarios(Nombres);

            UsersTxt.DataSource = Nombres;
            Us = null;
        }

        void PassTxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                Validar();
            }
        }
    }
}
