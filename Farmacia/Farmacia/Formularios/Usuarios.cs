using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        int Id { get; set; }
        private void Registrar_Click(object sender, EventArgs e)
        {
            Conexion Con = new Conexion();

            if (NombreTxt.Text != "" && ApellidoTxt.Text!= "" && DireccionTxt.Text != "")
            {
                if (TelefonoMasked.Text != "" && ContraseñaTxt.Text != "" && VerificarTxt.Text != "")
                {
                    if (Administrador.Text != "")
                    {
                        if(Administrador.Text== "True")
                        {
                            Con.Tipo_Users = true;
                        }
                        else
                        {
                            Con.Tipo_Users = false;
                        }

                        if (ContraseñaTxt.Text == VerificarTxt.Text)
                        {
                            Con.Insertar_Usuario(NombreTxt.Text,ApellidoTxt.Text,TelefonoMasked.Text,DireccionTxt.Text,ContraseñaTxt.Text);
                            MessageBox.Show("Usuario Agregado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("La Contraseña No Coincide");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellene Corectamente Los Campos");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Corectamente Los Campos");
                }
            }
            else
            {
                MessageBox.Show("Rellene Corectamente Los Campos");
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Conexion Con = new Conexion();
            DGU.DataSource = Con.Users();
        }
        
        private void DGU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Rows = DGU.Rows[e.RowIndex];

            Id = int.Parse(Rows.Cells["Id"].Value.ToString());
            NombreTxt.Text = Rows.Cells["Nombre"].Value.ToString();
            ApellidoTxt.Text = Rows.Cells["Apellido"].Value.ToString();
            TelefonoMasked.Text = Rows.Cells["Telefono"].Value.ToString();
            DireccionTxt.Text = Rows.Cells["Direccion"].Value.ToString();
            Administrador.Text = Rows.Cells["Administrador"].Value.ToString();
            Registrar.Enabled = false;

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar.Enabled = false;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar.Enabled = true;
            Actualizar.Enabled = false;

            NombreTxt.Text = "";
            ApellidoTxt.Text = "";
            TelefonoMasked.Text = "";
            DireccionTxt.Text = "";
            ContraseñaTxt.Text = "";
            Administrador.Text = "";
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Conexion Con = new Conexion();
            Con.Id_Usuario = Id.ToString();
            if (NombreTxt.Text != "" && ApellidoTxt.Text != "" && DireccionTxt.Text != "")
            {
                if (TelefonoMasked.Text != "" && ContraseñaTxt.Text != "" && VerificarTxt.Text != "")
                {
                    if (Administrador.Text != "")
                    {
                        if (Administrador.Text == "True")
                        {
                            Con.Tipo_Users = true;
                        }
                        else
                        {
                            Con.Tipo_Users = false;
                        }

                        if (ContraseñaTxt.Text == VerificarTxt.Text)
                        {
                            Con.Actualizar_Usuario(NombreTxt.Text, ApellidoTxt.Text, TelefonoMasked.Text, DireccionTxt.Text, ContraseñaTxt.Text);
                            MessageBox.Show("Usuario Actualizado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("La Contraseña No Coincide");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellene Corectamente Los Campos");
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Corectamente Los Campos");
                }
            }
            else
            {
                MessageBox.Show("Rellene Corectamente Los Campos");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion Con = new Conexion();

            Con.Id_Usuario = Id.ToString();
            Con.EliminarUsuario();
            MessageBox.Show("Usuario Eliminado");
        }
    }
}
