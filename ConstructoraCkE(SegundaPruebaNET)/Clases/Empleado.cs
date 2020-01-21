using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    class Empleado : Persona
    {
        private String cargo;
        public List<Empleado> misEmpleados = new List<Empleado>();

        public Empleado() {
            EmpleadosDefault();
        }

        public Empleado(String rut):base(rut) { }

        public Empleado(String rut, String nombre, String apellido, String cargo):base(rut,nombre,apellido) {
            this.Rut = rut;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.cargo = cargo;
        }

        public String Cargo {
            get { return cargo; }
            set { this.cargo = value; }
        }

        public void EmpleadosDefault() {
            this.misEmpleados.Add(new Empleado("1111111-1","Teresa","del los Andes","Ingeniera en Construcción"));
            this.misEmpleados.Add(new Empleado("2222222-2", "Jaime", "Barraza", "Arquitecto"));
            this.misEmpleados.Add(new Empleado("3333333-3", "Carmela", "Rojo", "Ingeniero Comercial"));
            this.misEmpleados.Add(new Empleado("4", "Pancracia", "Muños", "Ingeniero en Minas "));
            this.misEmpleados.Add(new Empleado("5", "Rupertina", "Caceres", "Ingeniero en Informática"));
            this.misEmpleados.Add(new Empleado("6", "Jacinta", "Berrios", "Tecnico en Construcción"));
            this.misEmpleados.Add(new Empleado("7", "Carmelo", "del Valle", "Ingeniero en Electricidad"));
            this.misEmpleados.Add(new Empleado("8", "Aurelio", "Vinagre", "Jardinero"));
            this.misEmpleados.Add(new Empleado("9", "Hugo", "Compuesto", "Topógrafo"));
        }


        public Empleado getEmpleado(int i) {
            String id = misEmpleados[i].Rut;
            String nombre = misEmpleados[i].Nombre;
            String apellido = misEmpleados[i].Apellido;
            String cargo = misEmpleados[i].Cargo;
            Empleado emp = new Empleado(id,nombre,apellido,cargo);
            return emp;
        }

        public void cargarEmpleados(ComboBox c)
        {
            c.DataSource = misEmpleados;
            c.DisplayMember = "Nombre";
        }
    }
}
