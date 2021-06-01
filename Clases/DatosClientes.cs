using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaCar
{
    public class DatosClientes
    {
        String nombre;
        String apellidos;
        String dni;
        String matricula;
        String marca;
        String modelo;
        String plazaParking;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string PlazaParking { get => plazaParking; set => plazaParking = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }

        public DatosClientes()
        {

        }

        public DatosClientes(string nombre, string apellidos, string dni, string matricula, string marca, string modelo, string plazaParking, DateTime fechaEntrada, DateTime fechaSalida)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Dni = dni;
            this.Matricula = matricula;
            this.Marca = marca;
            this.Modelo = modelo;
            this.PlazaParking = plazaParking;
            this.FechaEntrada = fechaEntrada;
            this.FechaSalida = fechaSalida;
        }

        override
        public String ToString()
        {
            return (Nombre +" "+ Apellidos );
        }
    }
}
