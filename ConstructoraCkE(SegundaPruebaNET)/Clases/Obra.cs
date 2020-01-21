using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    class Obra : Actividad
    {
        private int costoPresupuestado;
        private Empleado miEncargado;
        private Archivo miImagen;
        public static List<Obra> misObras = new List<Obra>();

        public Obra(){  
        }

        public Obra(String id) : base(id){
            this.Id = id;
        }

        public Obra(String id, DateTime fInicio, DateTime fTermino, String descripcion, int costoPresupuestado, Empleado miEncargado,Archivo miImagen) : base(id, fInicio, fTermino, descripcion)
        {
            this.Id = id;
            this.FInicio = fInicio;
            this.FTermino = fTermino;
            this.Descripcion = descripcion;
            this.costoPresupuestado = costoPresupuestado;
            this.miEncargado = miEncargado;
            this.miImagen = miImagen;
        }

        public int CostoPresupuestado
        {
            get { return costoPresupuestado; }
            set { this.costoPresupuestado = value; }
        }

        public Empleado MiEncargado
        {
            get { return miEncargado; }
            set { this.miEncargado = value; }
        }

        public Archivo MiImagen {
            get { return miImagen; }
            set { this.miImagen = value; }
        }


        public void ObrasDefault() {
            Empleado e = new Empleado();
            misObras.Add(new Obra("1", Convert.ToDateTime("01-01-2017"), Convert.ToDateTime("01-12-2017"), "Colegio El Sauce", 10000000, e.getEmpleado(0), new Archivo("1", "colegio.jpg")));
            misObras.Add(new Obra("2", Convert.ToDateTime("02-02-2016"), Convert.ToDateTime("01-12-2016"), "Hospital de Coquimbo", 20000000, e.getEmpleado(1), new Archivo("2", "hospital.jpg")));
            misObras.Add(new Obra("3", Convert.ToDateTime("12-03-2015"), Convert.ToDateTime("01-12-2017"), "Estadio La Serena", 30000000, e.getEmpleado(2), new Archivo("3", "estadio.jpg")));
            misObras.Add(new Obra("4", Convert.ToDateTime("21-05-2014"), Convert.ToDateTime("01-12-2017"), "Mall nuevoMall", 40000000, e.getEmpleado(3), new Archivo("4", "mall.jpg")));
            misObras.Add(new Obra("5", Convert.ToDateTime("07-02-2013"), Convert.ToDateTime("01-12-2017"), "Parque Urbano", 50000000, e.getEmpleado(4), new Archivo("5", "parque.jpg")));
            misObras.Add(new Obra("6", Convert.ToDateTime("30-07-2010"), Convert.ToDateTime("01-12-2017"), "Helipuerto", 60000000, e.getEmpleado(5), new Archivo("6", "helipuerto.jpg")));
        }


        public Obra getObra(int i) {
            String id = misObras[i].Id;
            DateTime fi = misObras[i].FInicio;
            DateTime ft = misObras[i].FTermino;
            int presupuesto = misObras[i].CostoPresupuestado;
            String des = misObras[i].Descripcion;
            Empleado encargado = misObras[i].MiEncargado;
            Archivo archivo = misObras[i].MiImagen;
            Obra obrita = new Obra(id, fi,ft, des,presupuesto,encargado,archivo);
            return obrita;
        }

        public void cargarObras(ComboBox c){
            c.DataSource = misObras;
            c.DisplayMember = "Descripcion";
        }



    }
}
