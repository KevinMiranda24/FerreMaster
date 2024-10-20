namespace FerreMaster.InterfazProducto
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Proveedor = new System.Windows.Forms.ComboBox();
            this.UnidadMedida = new System.Windows.Forms.ComboBox();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.Proveedor);
            this.groupBox1.Controls.Add(this.UnidadMedida);
            this.groupBox1.Controls.Add(this.Categoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // Proveedor
            // 
            this.Proveedor.FormattingEnabled = true;
            this.Proveedor.Location = new System.Drawing.Point(486, 62);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(121, 21);
            this.Proveedor.TabIndex = 9;
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.FormattingEnabled = true;
            this.UnidadMedida.Location = new System.Drawing.Point(486, 26);
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.UnidadMedida.TabIndex = 8;
            // 
            // Categoria
            // 
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(185, 102);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(121, 21);
            this.Categoria.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidad de medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(185, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio Unitario:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(185, 27);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(127, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(99, 268);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(554, 150);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(522, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.ComboBox Proveedor;
        private System.Windows.Forms.ComboBox UnidadMedida;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}