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
    public partial class V_MenuPrincipal : Form
    {
        public V_MenuPrincipal()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            V_Labor l = new V_Labor();
            l.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_Obra o = new V_Obra();
            o.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_Tarea t = new V_Tarea();
            t.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
