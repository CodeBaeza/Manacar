using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaCar.Clases
{
    class UsuariosSistema
    {
        string usuario;
        string password;

        public UsuariosSistema()
        {  
        }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        override
        public String ToString()
        {
            return (Usuario);
        }
    }
}
