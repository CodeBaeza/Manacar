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
    public partial class Registro : Form
    {
        Conexion con = new Conexion();
        public Registro()
        {

            InitializeComponent();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            DatosClientes dc = new DatosClientes(tbNombreR.Text, tbApellidosR.Text, tbDNIR.Text, tbMatriculaR.Text, tbMarcaR.Text, tbModeloR.Text, tbPlazaParking.Text, dtpFechaEntrada.Value, dtpFechaSalida.Value);
           
            if (dtpFechaEntrada.Value >= dtpFechaSalida.Value)
            {
                MessageBox.Show("Fecha de salida no puede ser igual o anterior a la fecha de entrada","Atención",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else if (tbDNIR.Text.Length == 0)
            {
                MessageBox.Show("El DNI es un campo obligatorio", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.insertarCliente(tbNombreR.Text, tbApellidosR.Text, tbDNIR.Text, dtpFechaEntrada.Value, dtpFechaSalida.Value, tbMatriculaR.Text, tbMarcaR.Text, tbModeloR.Text, tbPlazaParking.Text);
                ListViewItem lista = new ListViewItem(dc.PlazaParking);
                lista.SubItems.Add(dc.Nombre);
                lista.SubItems.Add(dc.Apellidos);
                lista.SubItems.Add(dc.Dni);
                lista.SubItems.Add(dc.Matricula);
                lista.SubItems.Add(dc.Marca);
                lista.SubItems.Add(dc.Modelo);
                lista.SubItems.Add(dc.FechaEntrada.ToString());
                lista.SubItems.Add(dc.FechaSalida.ToString());

                lvRegistroR.Items.Add(lista);

                tbNombreR.Text = "";
                tbApellidosR.Text = "";
                tbDNIR.Text = "";
                tbMatriculaR.Text = "";
                tbModeloR.Text = "";
                tbMarcaR.Text = "";
                tbPlazaParking.Text = "";
                MessageBox.Show("Cliente registrado satisfactoriamente en el sistema", "Registro", MessageBoxButtons.OK);
            }
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Registro - "+ us.Activo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreR.Text = "";
            tbApellidosR.Text = "";
            tbDNIR.Text = "";
            tbMatriculaR.Text = "";
            tbModeloR.Text = "";
            tbMarcaR.Text = "";
            tbPlazaParking.Text = "";
            
        }
    }
}

        
    

