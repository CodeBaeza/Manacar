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

namespace ManaCar.Formularios
{
    public partial class DatosEncontrados : Form
    {
        Conexion con = new Conexion();
        
        public DatosEncontrados()
        {
            InitializeComponent();
        }

        public void setDcData(DatosClientes dcData)
        {
            tbNombreEncontrado.Text = dcData.Nombre;
            tbApellidosEncontados.Text = dcData.Apellidos;
            tbDNIEncontrado.Text = dcData.Dni;
            dtpFechaEntrada.Value = dcData.FechaEntrada;
            dtpFechaSalida.Value = dcData.FechaSalida;
            tbMatriculaEncontrada.Text = dcData.Matricula;
            tbMarcaEncontrada.Text = dcData.Marca;
            tbModeloEncontrado.Text = dcData.Modelo;
            tbPlazaParkingEncontrado.Text = dcData.PlazaParking;
        }

        private void btnGuardarEncontrado_Click(object sender, EventArgs e)
        {
            DatosClientes dc = new DatosClientes();
            dc.Nombre = tbNombreEncontrado.Text;
            dc.Apellidos = tbApellidosEncontados.Text;
            dc.Dni = tbDNIEncontrado.Text;
            dc.FechaEntrada = dtpFechaEntrada.Value;
            dc.FechaSalida = dtpFechaSalida.Value;
            dc.Matricula = tbMatriculaEncontrada.Text;
            dc.Marca = tbMarcaEncontrada.Text;
            dc.PlazaParking = tbPlazaParkingEncontrado.Text;

            con.actualizarDatosClientes(dc.Nombre, dc.Apellidos, dc.Dni, dc.FechaEntrada, dc.FechaSalida, dc.Matricula, dc.Marca, dc.Modelo, dc.PlazaParking);
            MessageBox.Show("Datos actualizados correctamente");
            this.Close();
        }

        private void btnEliminarEncontrado_Click(object sender, EventArgs e)
        {          
            con.eliminarDatosClientes(tbDNIEncontrado.Text);
            MessageBox.Show("Datos eliminados correctamente");
            this.Close();
            Buscar bc = new Buscar();
            bc.Show();
        }

        private void DatosEncontrados_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Datos encontrado - " + us.Activo;
        }
    }
}
