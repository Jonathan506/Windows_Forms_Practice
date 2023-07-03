using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using CapaNegocio;
using capaDatos;
using System.Diagnostics;

namespace capaPresentacion
{
    public partial class frClientes : Form
    {

        CNcliente c = new CNcliente();
        public frClientes()
        {
            InitializeComponent();
        }

        private void frClientes_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos()
        {
            dataGridView1.DataSource = c.obtenerDatos().Tables["tb_usuario"];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm() 
        {
            numericUpDown1.Value = 0;
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void linkLabelSeleccionar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
            openFileDialog1.FileName = string.Empty;
        }
        clsCliente cliente = new clsCliente();
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool resultado = true;

            cliente.id = (int)numericUpDown1.Value;
            cliente.primerNombre = txtPrimerNombre.Text;
            cliente.segundoNombre = txtSegundoNombre.Text;
            cliente.primerApellido = txtPrimerApellido.Text;
            cliente.segundoApellido = txtSegundoApellido.Text;
            cliente.correo = txtCorreo.Text;
            cliente.foto = pictureBox1.ImageLocation;

            resultado = c.ValidarDatos(cliente);            

            if (resultado == false)
            {
                return;
            }

            if (cliente.id == 0) 
            {
                c.crearUsuario(cliente);
            }
            else
            {
                c.editarUsuario(cliente);
            }

            cargarDatos();
            LimpiarForm();

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frClientes.ActiveForm.Close();
        }
        private void conectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           c.conexion();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown1.Value = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            txtPrimerNombre.Text = dataGridView1.CurrentRow.Cells["primerNombre"].Value.ToString();
            txtSegundoNombre.Text = dataGridView1.CurrentRow.Cells["segundoNombre"].Value.ToString();
            txtPrimerApellido.Text = dataGridView1.CurrentRow.Cells["primerApellido"].Value.ToString();
            txtSegundoApellido.Text = dataGridView1.CurrentRow.Cells["segundoNombre"].Value.ToString();
            txtCorreo.Text = dataGridView1.CurrentRow.Cells["correo"].Value.ToString();
            pictureBox1.Load(dataGridView1.CurrentRow.Cells["foto"].Value.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0) return;
            if (MessageBox.Show("¿Deseas eliminar el registro?", "Titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cliente.id = (int)numericUpDown1.Value;
                c.EliminarUsuario(cliente);
                cargarDatos();
                LimpiarForm();
            }
        }
    }
}
