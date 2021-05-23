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
        const  int posicionNula = -1;
       
        
        static List<DatosClientes> ListaAuxiliar;
        Conexion con = new Conexion();



        public Registro()
        {

            InitializeComponent();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            DatosClientes dc = new DatosClientes(tbNombreR.Text, tbApellidosR.Text, tbDNIR.Text, tbMatriculaR.Text, tbMarcaR.Text, tbModeloR.Text, tbPlazaParking.Text, dtpFechaEntrada.Value, dtpFechaSalida.Value);
            con.insertarCliente(tbNombreR.Text, tbApellidosR.Text, tbDNIR.Text, dtpFechaEntrada.Value, dtpFechaSalida.Value, tbMatriculaR.Text, tbMarcaR.Text, tbModeloR.Text, tbPlazaParking.Text);
            ListViewItem lista = new ListViewItem(dc.PlazaParking);
            lista.SubItems.Add(dc.Nombre);
            lista.SubItems.Add(dc.Apellidos);
            lista.SubItems.Add(dc.Dni);
            lista.SubItems.Add(dc.Matricula);
            lista.SubItems.Add(dc.Marca);
            lista.SubItems.Add(dc.Modelo);
            lista.SubItems.Add(dc.FechaEntrada.ToString());
            lista.SubItems.Add(dc.FechaEntrada.ToString());


                    
            lvRegistroR.Items.Add(lista);
            
           
            

            tbNombreR.Text = "";
            tbApellidosR.Text = "";
            tbDNIR.Text = "";
            tbMatriculaR.Text = "";
            tbModeloR.Text = "";
            tbMarcaR.Text = "";
            tbPlazaParking.Text = "";



        }

            }



            /*
            if (posicion != posicionNula) //Controlamos si agregamos o modificamos.
            {
                ListaAuxiliar.RemoveAt(posicion);
                ListaAuxiliar.Add(du);
                posicion = posicionNula;
               
            }
            else
            {
                
                ListaAuxiliar.Add(du);
                

            }
            tbNombreR.Text = "";
            tbApellidosR.Text = "";
            tbDNIR.Text = "";
            tbMatriculaR.Text = "";
            tbModeloR.Text = "";
            tbMarcaR.Text = "";
            tbPlazaParking.Text = "";
            lbRegistro.Items.AddRange(ListaAuxiliar.ToArray());
            
            */

          
            


            }

        
    

