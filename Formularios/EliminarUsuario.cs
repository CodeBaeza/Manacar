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
            List<UsuariosSistema> auxiliar = new List<UsuariosSistema>();
            UsuarioActivo us = new UsuarioActivo();
            string usuario = tbEliminarUsuarioE.Text;
            if (usuario.Length <= 0)
            {
                MessageBox.Show("El campo esta vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (usuario.Length > 0)
            {
                if (con.buscarUsuarios(usuario) == usuario)
                {
                    if(usuario == us.Activo)
                    {
                        MessageBox.Show("No puedes eliminar el usuario que estas utilizando", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }else if((MessageBox.Show("Usuario: "+usuario+" encontrado, ¿Desea eliminarlo?","Aviso",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes) 
                    {
                        con.eliminarUsuario(usuario);
                        MessageBox.Show("Usuario eliminado satisfactoriamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbEliminarUsuarioE.Text = "";
                        lbUsuarios.Items.Clear();
                        auxiliar = con.mostrarLista();
                        lbUsuarios.Items.AddRange(auxiliar.ToArray());
                        

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
            List<UsuariosSistema> auxiliar = new List<UsuariosSistema>();
            lbUsuarios.Items.Clear();
            auxiliar = con.mostrarLista();
            lbUsuarios.Items.AddRange(auxiliar.ToArray());             
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Eliminar usuario - " + us.Activo;
        }
    }
}
