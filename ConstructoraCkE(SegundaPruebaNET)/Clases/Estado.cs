using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Clases
{
    public class Estado
    {
        private String id;
        private String descripcion;
        public List<Estado> misEstados = new List<Estado>();


        public Estado() {
            misEstados.Add(new Estado("0","Pendiente"));
            misEstados.Add(new Estado("1","Realizado"));
        }

        public Estado(String id) {
            this.id = id;
        }

        public Estado(String id,String descripcion) {
            this.id = id;
            this.descripcion = descripcion;
        }

        public String Id {
            get { return id; }
            set { this.id = value; }
        }

        public String Descripcion {
            get { return descripcion; }
            set { this.descripcion = value; }
        }

        public void cargarEstados(ComboBox cEstado) {
            cEstado.DataSource = misEstados;
            cEstado.DisplayMember = "Descripcion";
        }

        public Estado getEstado(ComboBox cEstado) {
            Estado estadito = (Estado)cEstado.SelectedItem;
            return estadito;
        }

    }
}
