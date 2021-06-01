using ManaCar.Clases;
using MySql.Data.MySqlClient;
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
    public partial class Inicio : Form
    {
        Conexion con = new Conexion();
        public Inicio()
        {          
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Length == 0 && tbPass.Text.Length == 0)
            {
                MessageBox.Show("Introduce tus credenciales", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Login(tbUsuario.Text, tbPass.Text);
                tbUsuario.Text = "";
                tbPass.Text = "";
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsuario.Text = "";
            tbPass.Text = "";
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere salir de la aplicacion", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
    


