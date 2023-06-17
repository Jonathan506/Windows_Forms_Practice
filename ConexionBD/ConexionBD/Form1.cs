using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConexionBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsConexion conexion = new clsConexion();
        private void bdconexion_Click(object sender, EventArgs e)
        {
            conexion.conectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void failToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        clsConexion obj = new clsConexion();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj.p_nombre = txtName.Text;
            obj.p_apellido = txtLastName.Text;
            obj.p_edad = int.Parse(txtAge.Text);

            obj.insertar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            obj.id = int.Parse(txtsearch.Text);
            obj.buscar(dataGridView1);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            obj.visualizar(dataGridView1);
        }

        private void cLoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            obj.p_id = int.Parse(txtid.Text);
            obj.eliminar(dataGridView1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            obj.p_id= int.Parse(txtid.Text);
            obj.p_nombre = txtName.Text;
            obj.p_apellido = txtLastName.Text;
            obj.p_edad = int.Parse(txtAge.Text);

            obj.actualizar();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtLastName.Clear();
            txtLastName.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtsearch.Clear();
        }
    }
}
