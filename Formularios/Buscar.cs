using ManaCar.Clases;
using ManaCar.Formularios;
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
    public partial class Buscar : Form
    {
        
        Conexion con = new Conexion();
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            List<DatosClientes> auxiliar = new List<DatosClientes>();
           
            lbUsuarios.Items.Clear();

            if (tbBuscarDNI.Text.Length > 0)
            {
                auxiliar = con.MostrarCliente(tbBuscarDNI.Text);
                lbUsuarios.Items.AddRange(auxiliar.ToArray());
            }
            else
            {
                auxiliar = con.MostrarTodosLosClientes();
                lbUsuarios.Items.AddRange(auxiliar.ToArray());
            }
            
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DatosClientes dc = (DatosClientes)lbUsuarios.SelectedItem;
            if( dc!= null){
                DatosEncontrados de = new DatosEncontrados();
               
                de.setDcData(dc);
                de.ShowDialog();
                this.Close();
            }          
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Buscar, Usuario Activo: " + us.Activo;
        }
    }
}
