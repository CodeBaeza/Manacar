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
    
    public partial class EliminarUsuario : Form
    {
        Conexion con = new Conexion();
       
       
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            string usuario = tbEliminarUsuarioE.Text;
            if (usuario.Length <= 0)
            {
                MessageBox.Show("No puedes dejar el campo vacio si deseas eliminar ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (usuario.Length > 0)
            {
                if (con.buscarUsuarios(usuario) == usuario)
                {
                    if((MessageBox.Show("Usuario: "+usuario+" encontrado, ¿Desea eliminarlo?","Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes) {
                        con.eliminarUsuario(usuario);
                        MessageBox.Show("Usuario eliminado satisfactoriamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbEliminarUsuarioE.Text = "";
                        dgvMostrarUsuarios.DataSource= con.mostrarLista();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado, compruebe que el usuario esta bien escrito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEliminarUsuarioE.Text = "";
                }
                
                
            }
            else
            {
                MessageBox.Show("El usuario no se encuentra en la base de datos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
      
            dgvMostrarUsuarios.DataSource = con.mostrarLista();
            

            
        }
    }
}
