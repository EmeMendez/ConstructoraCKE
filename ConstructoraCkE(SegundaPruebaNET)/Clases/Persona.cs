using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    abstract class  Persona
    {
        private String rut;
        private String nombre;
        private String apellido;

        public Persona() { }

        public Persona(String id) { }

        public Persona(String rut, String nombre,String apellido ) {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public String Rut {
            get { return rut; }
            set { this.rut = value; }
        }

        public String Nombre {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public String Apellido {
            get { return apellido; }
            set { this.apellido = value; }
        }
    }
}
