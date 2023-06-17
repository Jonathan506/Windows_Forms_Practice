using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cls_Arreglo obj = new Cls_Arreglo();
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            obj.ingresar();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            obj.mostrar(listBox1 );
        }
    }
}
