using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        double num1 = 0.0;
        double num2 = 0.0;
        double operacion = 0.0;

        private void btn2_Click(object sender, EventArgs e)
        {
            firstnumber.Clear();
            secondnumber.Clear();
            Respuesta.Clear();
        }

        public void Asignacion() 
        {
            firstnumber.Text = firstnumber.Text.Replace(".", ",");
            secondnumber.Text = secondnumber.Text.Replace(".", ",");
            num1 = Convert.ToDouble(firstnumber.Text);
            num2 = Convert.ToDouble(secondnumber.Text);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Sumatoria();
        }

        public void Sumatoria() 
        {
            try
            {
                Asignacion();
                operacion = num1 + num2;

                Respuesta.Text = operacion.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            resta();
        }

        public void resta()
        {
            try
            {
                Asignacion();

                operacion = num1 - num2;

                Respuesta.Text = operacion.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btmmultiplicacion_Click(object sender, EventArgs e)
        {
            multiplicacion();
        }

        public void multiplicacion()
        {
            try
            {
                Asignacion();

                operacion = num1 * num2;

                Respuesta.Text = operacion.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Division();
        }

        public void Division()
        {
            try
            {
                Asignacion();

                operacion = num1 / num2;

                Respuesta.Text = operacion.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}