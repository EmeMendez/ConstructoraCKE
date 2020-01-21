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

namespace ConstructoraCkE_SegundaPruebaNET_
{
    public partial class V_Principal : Form
    {
        Empleado e = new Empleado();
        public V_Principal()
        {
            InitializeComponent();
            comboEmpleados.DataSource = e.misEmpleados;
            comboEmpleados.DisplayMember = "Nombre";

        }
    }
}
