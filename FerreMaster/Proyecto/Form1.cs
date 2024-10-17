using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

 
            ConfigurarDataGridView();

            
        }

        private void ConfigurarDataGridView()
        {
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            
            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn();
            columnaNombre.HeaderText = "Nombre del Producto";
            columnaNombre.DataPropertyName = "Nombre"; 
            columnaNombre.Width = 200;
            dataGridView1.Columns.Add(columnaNombre);

            DataGridViewTextBoxColumn columnaPrecio = new DataGridViewTextBoxColumn();
            columnaPrecio.HeaderText = "Precio Unitario";
            columnaPrecio.DataPropertyName = "Precio";
            columnaPrecio.Width = 100;
            dataGridView1.Columns.Add(columnaPrecio);

            DataGridViewTextBoxColumn columnaUnidadMedida = new DataGridViewTextBoxColumn();
            columnaUnidadMedida.HeaderText = "Unidad de Medida";
            columnaUnidadMedida.DataPropertyName = "UnidadMedida";
            columnaUnidadMedida.Width = 150;
            dataGridView1.Columns.Add(columnaUnidadMedida);

            DataGridViewTextBoxColumn columnaProveedor = new DataGridViewTextBoxColumn();
            columnaProveedor.HeaderText = "Proveedor";
            columnaProveedor.DataPropertyName = "Proveedor";
            columnaProveedor.Width = 150;
            dataGridView1.Columns.Add(columnaProveedor);

            DataGridViewTextBoxColumn columnaCategoria = new DataGridViewTextBoxColumn();
            columnaCategoria.HeaderText = "Categoría";
            columnaCategoria.DataPropertyName = "Categoria";
            columnaCategoria.Width = 150;
            dataGridView1.Columns.Add(columnaCategoria);
        }

       
    }
}
