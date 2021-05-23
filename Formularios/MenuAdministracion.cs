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
    public partial class MenuAdministracion : Form
    {
        public MenuAdministracion()
        {

            InitializeComponent();
        }

        private void btnRegistroA_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.ShowDialog();
        }
        private void btnModificarA_Click(object sender, EventArgs e)
        {
            Buscar b = new Buscar();
            b.ShowDialog();
        }
     


                 

      

        

        

       

       

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quiere cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario nu = new NuevoUsuario();
            nu.ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarUsuario eu = new EliminarUsuario();
            eu.ShowDialog();
        }

        private void copiaSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopiaSeguridad cs = new CopiaSeguridad();
            cs.ShowDialog();
        }
    }
}
