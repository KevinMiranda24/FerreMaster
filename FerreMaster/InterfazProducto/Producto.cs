using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreMaster.InterfazProducto
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }


        private void ConfigurarDataGridView()
        {
            dataGridViewProductos.AutoGenerateColumns = false;
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.ReadOnly = true;

            DataGridViewTextBoxColumn columnaNombre = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre del Producto",
                DataPropertyName = "Nombre",
                Width = 200
            };
            dataGridViewProductos.Columns.Add(columnaNombre);

            DataGridViewTextBoxColumn columnaPrecio = new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio Unitario",
                DataPropertyName = "Precio",
                Width = 100
            };
            dataGridViewProductos.Columns.Add(columnaPrecio);

            DataGridViewTextBoxColumn columnaUnidadMedida = new DataGridViewTextBoxColumn
            {
                HeaderText = "Unidad de Medida",
                DataPropertyName = "UnidadMedida",
                Width = 150
            };
            dataGridViewProductos.Columns.Add(columnaUnidadMedida);

            DataGridViewTextBoxColumn columnaProveedor = new DataGridViewTextBoxColumn
            {
                HeaderText = "Proveedor",
                DataPropertyName = "Proveedor",
                Width = 150
            };
            dataGridViewProductos.Columns.Add(columnaProveedor);

            DataGridViewTextBoxColumn columnaCategoria = new DataGridViewTextBoxColumn
            {
                HeaderText = "Categoría",
                DataPropertyName = "Categoria",
                Width = 150
            };
            dataGridViewProductos.Columns.Add(columnaCategoria);
        }


        public class ProductoModel
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public string UnidadMedida { get; set; }
            public string Proveedor { get; set; }
            public string Categoria { get; set; }
        }


        private List<ProductoModel> listaProductos = new List<ProductoModel>();


        private void button1_Click(object sender, EventArgs e)
        {
            ProductoModel producto = new ProductoModel
            {
                Nombre = txtNombreProducto.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                UnidadMedida = UnidadMedida.SelectedItem.ToString(),
                Proveedor = Proveedor.SelectedItem.ToString(),
                Categoria = Categoria.SelectedItem.ToString()
            };

            listaProductos.Add(producto);

            ActualizarDataGridView();
            LimpiarCampos();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int index = dataGridViewProductos.CurrentRow.Index;
                ProductoModel producto = listaProductos[index];

                producto.Nombre = txtNombreProducto.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Categoria = Categoria.SelectedItem.ToString();
                producto.UnidadMedida = UnidadMedida.SelectedItem.ToString();
                producto.Proveedor = Proveedor.SelectedItem.ToString();

                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                int index = dataGridViewProductos.CurrentRow.Index;
                listaProductos.RemoveAt(index);

                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string searchValue = txtNombreProducto.Text;
            var productosFiltrados = listaProductos
                .Where(p => p.Nombre.ToLower().Contains(searchValue.ToLower()))
                .ToList();

            if (productosFiltrados.Any())
            {
                dataGridViewProductos.DataSource = null;
                dataGridViewProductos.DataSource = productosFiltrados;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }


        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];
                txtNombreProducto.Text = row.Cells[0].Value.ToString();
                txtPrecio.Text = row.Cells[1].Value.ToString();
                Categoria.SelectedItem = row.Cells[2].Value.ToString();
                UnidadMedida.SelectedItem = row.Cells[3].Value.ToString();
                Proveedor.SelectedItem = row.Cells[4].Value.ToString();
            }
        }


        private void ActualizarDataGridView()
        {
            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = listaProductos;
        }


        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtPrecio.Clear();
        }
    }
}

