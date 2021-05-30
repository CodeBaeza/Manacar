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
        Backup bp;
        Conexion con = new Conexion();
        static List<Backup> listaBackup;
        
        public CopiaSeguridad()
        {
            InitializeComponent();
        }

        private void CopiaSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void btnPathCopia_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog copiaDestino = new FolderBrowserDialog();
            if (copiaDestino.ShowDialog() == DialogResult.OK) ;
            tbPathCS.Text = copiaDestino.SelectedPath;
        }

        private void btnGuardarCS_Click(object sender, EventArgs e)
        {
            string nombreDocumento = tbNombreCS.Text;
            string ruta = tbPathCS.Text;
            bp = new Backup(tbNombreCS.Text, dtpFechaCS.Value, tbPathCS.Text);
            ListViewItem listaCopiaSeguridad = new ListViewItem(bp.Nombre);
                listaCopiaSeguridad.SubItems.Add(bp.Path);
                listaCopiaSeguridad.SubItems.Add(bp.Fecha.ToString());
                lvHistorialCopiaCS.Items.Add(listaCopiaSeguridad);
                //listaBackup.Add(bp);
                con.BackUpDataBase(nombreDocumento,ruta);

            


        }
    }
}
