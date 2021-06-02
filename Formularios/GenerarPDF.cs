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
    public partial class Generar_PDF : Form
    {
       
        Conexion con = new Conexion();
        public Generar_PDF()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaEntrada.Value >= dtpFechaSalida.Value)
            {
                MessageBox.Show("Fecha de salida no puede ser igual o anterior a la fecha de entrada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPDFName.Text.Length == 0)
            {
                MessageBox.Show("Introduzca el nombre del fichero .pdf", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.generarPDF(dtpFechaEntrada.Value, dtpFechaSalida.Value, tbPDFName.Text);
                DocumentoPDF generarPdf = new DocumentoPDF();
                generarPdf.Show();
            }           
        }
        private void Generar_PDF_Load(object sender, EventArgs e)
        {
            UsuarioActivo us = new UsuarioActivo();
            this.Text = "Generar PDF - " + us.Activo;
        }
    }
}
