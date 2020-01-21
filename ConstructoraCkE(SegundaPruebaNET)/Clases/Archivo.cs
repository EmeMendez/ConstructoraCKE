using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    class Archivo
    {
        private String id;
        private String ruta;
        public static List<Archivo> misImagenes = new List<Archivo>();

        public Archivo() {
            imagenesDefault();
        }

        public Archivo(String id, String ruta) {
            this.id = id;
            this.ruta = ruta;
        }

        public String Id{
            get { return id; }
            set { this.id = value; }
        }

        public String Ruta {
            get { return ruta; }
            set { this.ruta = value; }
        }


        public void imagenesDefault() {
            misImagenes.Add(new Archivo("1", "colegio.jpg"));
            misImagenes.Add(new Archivo("2", "hospital.jpg"));
            misImagenes.Add(new Archivo("3", "estadio.jpg"));
            misImagenes.Add(new Archivo("4", "mall.jpg"));
            misImagenes.Add(new Archivo("5", "parque.jpg"));
            misImagenes.Add(new Archivo("6", "helipuerto.jpg"));
        }



    }
}
