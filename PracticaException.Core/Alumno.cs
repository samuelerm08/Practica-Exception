using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticaException.Core
{
    public class Alumno
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede estar vacío o superar los 50 carácteres");
                }

                nombre = value.Trim();
            }
        }
    }
}
