using ConstructoraCkE_SegundaPruebaNET_.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructoraCkE_SegundaPruebaNET_.Vistas
{
    public partial class V_Obra : Form
    {
        static int iden = 6;
        String dir;
        Obra o = new Obra();
        OpenFileDialog abrir = new OpenFileDialog();
        static Archivo a = new Archivo(iden.ToString(), ("default.png"));

        Empleado e = new Empleado();
        public V_Obra()
        { 
            InitializeComponent();
            Bitmap i = new Bitmap("C:/Users/Melón/Documents/Visual Studio 2017/Projects/ConstructoraCkE(SegundaPruebaNET)/ConstructoraCkE(SegundaPruebaNET)/img/default.png");
            picc.Image = (Image)i;
            e.cargarEmpleados(comboEmpleado);
            mostrarTabla();
            picc.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void nuevaObra() {
            iden++;
            String des = txt_descripcion.Text;
            DateTime i = inicio.Value;
            DateTime t = termino.Value;
            int costo = Convert.ToInt32(txt_costo.Value);
            String final = "C:/Users/Melón/Documents/Visual Studio 2017/Projects/ConstructoraCkE(SegundaPruebaNET)/ConstructoraCkE(SegundaPruebaNET)/img/" + abrir.SafeFileName;
            try { File.Copy(abrir.FileName, final, true);
                a = new Archivo(iden.ToString(), abrir.SafeFileName);
            }
            catch (Exception) {
            }
            Empleado e = (Empleado)comboEmpleado.SelectedItem ;
            Obra o = new Obra(iden.ToString(), i, t, des, costo, e, a);
            Obra.misObras.Add(o);
            MessageBox.Show("Obra ingresada correctamente");
            mostrarTabla();
            limpiarCampos();
        }


        public void limpiarCampos() {
            Bitmap u = new Bitmap("C:/Users/Melón/Documents/Visual Studio 2017/Projects/ConstructoraCkE(SegundaPruebaNET)/ConstructoraCkE(SegundaPruebaNET)/img/default.png");
            picc.Image = (Image)u;
            picc.SizeMode = PictureBoxSizeMode.StretchImage;
            a = new Archivo(iden.ToString(), ("default.png"));
            txt_costo.Value = 0;
            txt_descripcion.Text = "";
            inicio.Value = DateTime.Today;
            termino.Value = DateTime.Today;
        }

        public void mostrarTabla()
        {
            for (int i = 0; i < Obra.misObras.Count; i++)
            {   
                tablaObras.Rows.Add();
                tablaObras[0, i].Value = Obra.misObras[i].Id;
                tablaObras[1, i].Value = Obra.misObras[i].Descripcion;
                tablaObras[2, i].Value = Obra.misObras[i].FInicio.ToShortDateString();
                tablaObras[3, i].Value = Obra.misObras[i].FTermino.ToShortDateString();
                tablaObras[4, i].Value = Obra.misObras[i].MiEncargado.Nombre;
                tablaObras[5, i].Value = Obra.misObras[i].MiImagen.Ruta;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e){
            nuevaObra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_MenuPrincipal p = new V_MenuPrincipal();
            p.Visible = true;
            this.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            o.ObrasDefault();
            mostrarTabla();
        }

        private void termino_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrir.Filter = "Archivos JPG y PNG(*.jpg)|*.jpg";
            abrir.InitialDirectory = "../Downloads";
            if (abrir.ShowDialog() == DialogResult.OK) {
                dir= abrir.FileName;
                Bitmap img = new Bitmap(dir);
                picc.Image = (Image)img;
            }

        }
    }
}
