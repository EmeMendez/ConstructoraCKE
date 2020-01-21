using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    abstract class Actividad
    {
        private String id;
        private DateTime fInicio;
        private DateTime fTermino;
        private String descripcion;

        public Actividad() { }

        public Actividad(String id) { }

        public Actividad(String id,DateTime fInicio, DateTime fTermino,String descripcion) {
            this.id = id;
            this.fInicio = fInicio;
            this.fTermino = fTermino;
            this.descripcion = descripcion;
        }

        public String Id {
            get { return id; }
            set { this.id = value; }
        }

        public DateTime FInicio {
            get { return fInicio; }
            set { this.fInicio = value; }
        }

        public DateTime FTermino {
            get { return fTermino; }
            set { this.fTermino = value; }
        }

        public String Descripcion {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

    }
}
