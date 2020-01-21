using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    class Tarea : Actividad
    {
        private Obra miObra;
        private double porcentaje;
        public static List<Tarea> misTareas = new List<Tarea>();

        public Tarea() { }

        public Tarea(String id):base(id){
            this.Id = id;
        }

        public Tarea(String id, DateTime fInicio, DateTime fTermino, String descripcion,Obra miObra,int porcentaje):base(id,fInicio,fTermino,descripcion) {
            this.Id = id;
            this.FInicio = FInicio;
            this.FTermino = FTermino;
            this.Descripcion = descripcion;
            this.miObra = miObra;
            this.porcentaje = porcentaje;
        }

        public Obra MiObra {
            get { return miObra; }
            set { this.miObra = value; }
        }

        public double Porcentaje {
            get {return porcentaje; }
            set { this.porcentaje = value; }
        }
 

        public List<Tarea> getTareas(String id){
            List<Tarea> asociadas = misTareas.FindAll(tar => tar.MiObra.Id == id);
            return asociadas;
        }


        //public bool existe(String id){
        //    bool existe = misTareas.Exists(t => t.Id==id);
        //    return existe;
        //}
    }
}
