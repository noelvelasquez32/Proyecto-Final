using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Usuariovendedor
    {
        private int id;
        private string usuario;
        private string contrasena;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public Usuariovendedor()
        {

        }

        public Usuariovendedor(int id, string usuario, string contrasena)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Contrasena = contrasena;
            
        }

    }
}
