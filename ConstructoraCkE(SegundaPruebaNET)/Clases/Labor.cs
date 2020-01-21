using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    class Labor : Actividad
    {
        private Tarea miTarea;
        private Empleado miEmpleado;
        private Estado miEstado;
        private double porcentaje;
        public static List<Labor> misLabores = new List<Labor>();

        public Labor() { }

        public Labor(String id) : base(id) {
            this.Id = id;
        }

        public Labor(String id, DateTime fInicio, DateTime fTermino, String descripcion, Tarea miTarea, Empleado miEmpleado, Estado miEstado) : base(id, fInicio, fTermino, descripcion) {
            this.Id = id;
            this.FInicio = fInicio;
            this.FTermino = FTermino;
            this.Descripcion = descripcion;
            this.miTarea = miTarea;
            this.miEmpleado = miEmpleado;
            this.miEstado = miEstado;
        }

        public Tarea MiTarea {
            get { return miTarea; }
            set { this.miTarea = value; }
        }

        public Empleado MiEmpleado {
            get { return miEmpleado; }
            set { this.miEmpleado = value; }
        }

        public Estado MiEstado {
            get { return miEstado; }
            set { this.miEstado = value; }
        }

        public double Porcentaje {
            get { return porcentaje; }
            set { this.porcentaje = value; }
        }

        public void cambiarEstado(String id) {
            //*****
            //*****
            //*****
        }

        public List<Labor> getLabores(String idObra, String idTarea) {
            List<Labor> asociadas = misLabores.FindAll(lab => lab.MiTarea.Id == idTarea && lab.MiTarea.MiObra.Id == idObra);
            return asociadas;
        }



        //sacar el porcentaje de equivalencia
        public double calcular(String idObra, String idTarea)
        {
            double por = 0;
            List<Labor> asociadas = getLabores(idObra,idTarea);
            double contador = asociadas.Count;
            if (contador != 0){
                por = 100 / contador;
                for (int i = 0; i < asociadas.Count; i++) {
                    asociadas[i].Porcentaje=por;
                }

            }

            return por;
        }


        public void setPorcentajeTarea(Tarea tareita,String idObra) {
            tareita.Porcentaje = 0;
            List<Labor> asociadas = getLabores(idObra,tareita.Id);
            List<Labor> asoc = asociadas.FindAll(lab => lab.MiEstado.Id == "1");
            for(int i = 0; i<asoc.Count;i++)
                tareita.Porcentaje = tareita.Porcentaje + asoc[i].Porcentaje;
            }
        
        }

}

