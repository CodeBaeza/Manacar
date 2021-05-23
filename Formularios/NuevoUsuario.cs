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
                MessageBox.Show("Introduce el usuario","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if (tbContraseñaN.Text.Length == 0)
            {
                MessageBox.Show("Selecciona el privilegio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                con.nuevoUsuario(tbUsuarioN.Text,tbContraseñaN.Text);
                MessageBox.Show("Usuario creado satisfactoriamente","Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuarioN.Text = "";
                tbContraseñaN.Text = ""; 
            }
        }

        private void btnLimpiarN_Click(object sender, EventArgs e)
        {
            tbUsuarioN.Text ="";
            tbContraseñaN.Text ="";
            


        }
    }
}
