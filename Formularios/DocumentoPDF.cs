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
   
    public partial class DocumentoPDF : Form
    {
        Conexion con = new Conexion();
        public DocumentoPDF()
        {
            InitializeComponent();
            con.generarPDF();
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.ShowDialog();
            axAcroPDF1.src = abrir.FileName;



        }
    }
}
