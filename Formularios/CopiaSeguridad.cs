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
    public partial class CopiaSeguridad : Form
    {       
        Conexion con = new Conexion();
        
        public CopiaSeguridad()
        {
            InitializeComponent();
        }

        private void CopiaSeguridad_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Copia de seguridad - " + us.Activo;
        }

        private void btnPathCopia_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog copiaDestino = new FolderBrowserDialog();
            if (copiaDestino.ShowDialog() == DialogResult.OK)
            {
                tbPathCS.Text = copiaDestino.SelectedPath;
            }
        }

        private void btnGuardarCS_Click(object sender, EventArgs e)
        {
            string nombreDocumento = tbNombreCS.Text;
            string ruta = tbPathCS.Text;
            if (tbNombreCS.Text.Length == 0)
            {
                MessageBox.Show("Introduzca el nombre del fichero .sql", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (ruta.Length == 0)
            {
                MessageBox.Show("Introduzca una ruta valida para guardar el fichero .sql", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.BackUpDataBase(nombreDocumento, ruta);
                MessageBox.Show("Copia de seguridad guardada correctamente", "Copia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
