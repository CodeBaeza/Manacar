using ManaCar.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaCar
{
    public partial class NuevoUsuario : Form
    {
        Conexion con = new Conexion();
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearUsuarioN_Click(object sender, EventArgs e)
        {           
            if (tbUsuarioN.Text.Length == 0)
            {           
            MessageBox.Show("Introduzca el usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                 
            }
            else if (tbContraseñaN.Text.Length == 0)
            {
                MessageBox.Show("Introduzca una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (con.comprobarUsuario(tbUsuarioN.Text) == true)
                {
                    MessageBox.Show("El nombre del usuario ya esta registrado en el sistema.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else 
                {
                    con.nuevoUsuario(tbUsuarioN.Text, tbContraseñaN.Text);
                    MessageBox.Show("Usuario creado satisfactoriamente.", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUsuarioN.Text = "";
                    tbContraseñaN.Text = "";
                }
            }
        }

        private void btnLimpiarN_Click(object sender, EventArgs e)
        {
            tbUsuarioN.Text ="";
            tbContraseñaN.Text ="";
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Nuevo usuario - " + us.Activo;
        }
        
    }
}
