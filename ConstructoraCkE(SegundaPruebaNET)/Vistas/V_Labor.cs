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
    public partial class V_Labor : Form
    {
        static int iden = 0;
        Empleado e = new Empleado();
        Obra o = new Obra();
        Tarea miTarea = new Tarea();
        Labor l = new Labor();
        Estado es = new Estado();
        Archivo a = new Archivo();

        public V_Labor(){
            InitializeComponent();
            e.cargarEmpleados(comboEmpleado);
            o.cargarObras(comboObras);
            c_combo.DataSource = es.misEstados;
            c_combo.DisplayMember = "Descripcion";
            mostrarImagen();
        }

        public void nuevaLabor() {
            try{
            iden++;
            String des = txt_descripcion.Text;
            DateTime max = maximo.Value;
            miTarea = (Tarea)comboTareas.SelectedItem;
            Obra miObra = (Obra)comboObras.SelectedItem;
            Empleado miEmpleado = (Empleado)comboEmpleado.SelectedItem;
            Estado miEstado = suEstado();
            Labor labor = new Labor(iden.ToString(), DateTime.Now, max, des, miTarea, miEmpleado, miEstado);
            Labor.misLabores.Add(labor);
            labor.Porcentaje = l.calcular(miObra.Id, miTarea.Id);
            labor.setPorcentajeTarea(miTarea, miObra.Id);
            mostrarTabla(miObra.Id, miTarea.Id);
            }catch (Exception e) {
                MessageBox.Show("Valor de obra o tarea no existe");
            }
    }
        public void mostrarTabla(String idObra,String idTarea)
        {
            tablaLabores.Rows.Clear();
            List<Labor> misLabores = l.getLabores(idObra,idTarea);

            for (int i = 0; i < misLabores.Count; i++)
            {
                tablaLabores.Rows.Add();
                tablaLabores[0, i].Value = misLabores[i].Id;
                tablaLabores[1, i].Value = misLabores[i].Descripcion;
                tablaLabores[2, i].Value = misLabores[i].FInicio.ToShortDateString();
                tablaLabores[3, i].Value = misLabores[i].FTermino.ToShortDateString();
                tablaLabores[4, i].Value = misLabores[i].MiEmpleado.Nombre;
                tablaLabores[5, i].Value = misLabores[i].MiEstado.Descripcion;
                tablaLabores[6, i].Value = misLabores[i].Porcentaje;
            }
        }
        ///este estrado
        public Estado suEstado() {
            Estado miEstado = new Estado();
            if (check_estado.Checked == true){
                miEstado = new Estado("1", "Realizado");
            }
            else {
                miEstado = new Estado("0", "Pendiente");
            }
            return miEstado;
        }

        public void mostrarImagen() {
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Obra ob = (Obra)comboObras.SelectedItem;
            try
            {
                String dir = "C:/Users/Melón/Documents/Visual Studio 2017/Projects/ConstructoraCkE(SegundaPruebaNET)/ConstructoraCkE(SegundaPruebaNET)/img/" + ob.MiImagen.Ruta;
                Bitmap img = new Bitmap(dir);
                pic.Image = (Image)img;
            }
            catch (Exception exe) {
                Bitmap i = new Bitmap("C:/Users/Melón/Documents/Visual Studio 2017/Projects/ConstructoraCkE(SegundaPruebaNET)/ConstructoraCkE(SegundaPruebaNET)/img/default.png");
                pic.Image = (Image)i;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_MenuPrincipal p = new V_MenuPrincipal();
            p.Visible = true;
            this.Visible = false;
        }

        private void comboObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Obra ob = (Obra)comboObras.SelectedItem;
            mostrarImagen();
            lbl_obra.Text = ob.Descripcion;
            try
            {
            List<Tarea> asociadas = miTarea.getTareas(ob.Id);
            comboTareas.Text = "";
            comboTareas.DataSource = asociadas;
            comboTareas.DisplayMember = "Descripcion";

                Tarea ta = (Tarea)comboTareas.SelectedItem;
                mostrarTabla(ob.Id,ta.Id);
                lbl_tarea.Text = ta.Descripcion;
            }
            catch (Exception ex ) {
                lbl_tarea.Text = "**Sin tareas**";
            }

        }

        private void comboTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_tarea.Text = comboTareas.Text;
            mostrarTabla(((Obra)comboObras.SelectedItem).Id,((Tarea)comboTareas.SelectedItem).Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevaLabor();
        }
    }
}
