using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaCar
{
    class Backup
    {
        string nombre;
        DateTime fecha;
        string path;

        public Backup(string nombre, DateTime fecha, string path)
        {
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Path = path;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Path { get => path; set => path = value; }
    }
}
