using ConstructoraCkE_SegundaPruebaNET_.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Vistas
{

    public partial class V_Tarea : Form
    {
        Obra o = new Obra();
        static int iden = 0;
        public V_Tarea()
        {
            InitializeComponent();
            o.cargarObras(comboObras);
        }

        public void nuevaTarea()
        {
            iden++;
            String des = txt_descripcion.Text;
            DateTime ini = inicio.Value;
            DateTime ter = termino.Value;
            int porcentaje = 0;
            Obra obra = (Obra)comboObras.SelectedItem; 
            Tarea t = new Tarea(iden.ToString(),ini,ter,des,obra,porcentaje);
            Tarea.misTareas.Add(t);
            mostrarTabla(((Obra)comboObras.SelectedItem).Id);
        }

        public void mostrarTabla(String id)
        {
            tablaTareas.Rows.Clear();
            Tarea t = new Tarea();
            List<Tarea> misTareas = t.getTareas(id);

            for (int i = 0; i < misTareas.Count; i++)
            {
                tablaTareas.Rows.Add();
                tablaTareas[0, i].Value = misTareas[i].Id;
                tablaTareas[1, i].Value = misTareas[i].Descripcion;
                tablaTareas[2, i].Value = misTareas[i].FInicio.ToShortDateString();
                tablaTareas[3, i].Value = misTareas[i].FTermino.ToShortDateString();
                tablaTareas[4, i].Value = misTareas[i].Porcentaje;

            }
        }

        private void comboObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = ((Obra)comboObras.SelectedItem).Id;
            mostrarTabla(id);
            lbl_nombre.Text = ((Obra)comboObras.SelectedItem).Descripcion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevaTarea();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_MenuPrincipal p = new V_MenuPrincipal();
            p.Visible = true;
            this.Visible = false;
        }

        private void comboObras_SelectedItemChanged(object sender, EventArgs e)
        {
            String id = ((Obra)comboObras.SelectedItem).Id;
            mostrarTabla(id);
            lbl_nombre.Text = ((Obra)comboObras.SelectedItem).Descripcion;

        }
    }
}
