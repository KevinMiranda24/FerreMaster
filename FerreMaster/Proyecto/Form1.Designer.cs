namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_agregarproducto = new System.Windows.Forms.Button();
            this.btn_Editarproducto = new System.Windows.Forms.Button();
            this.btn_Eliminarproducto = new System.Windows.Forms.Button();
            this.btn_Buscarproducto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 357);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_agregarproducto
            // 
            this.btn_agregarproducto.Location = new System.Drawing.Point(37, 286);
            this.btn_agregarproducto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_agregarproducto.Name = "btn_agregarproducto";
            this.btn_agregarproducto.Size = new System.Drawing.Size(235, 51);
            this.btn_agregarproducto.TabIndex = 1;
            this.btn_agregarproducto.Text = "Agregar producto";
            this.btn_agregarproducto.UseVisualStyleBackColor = true;
            // 
            // btn_Editarproducto
            // 
            this.btn_Editarproducto.Location = new System.Drawing.Point(322, 286);
            this.btn_Editarproducto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Editarproducto.Name = "btn_Editarproducto";
            this.btn_Editarproducto.Size = new System.Drawing.Size(210, 51);
            this.btn_Editarproducto.TabIndex = 2;
            this.btn_Editarproducto.Text = "Editar producto";
            this.btn_Editarproducto.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminarproducto
            // 
            this.btn_Eliminarproducto.Location = new System.Drawing.Point(565, 286);
            this.btn_Eliminarproducto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Eliminarproducto.Name = "btn_Eliminarproducto";
            this.btn_Eliminarproducto.Size = new System.Drawing.Size(200, 51);
            this.btn_Eliminarproducto.TabIndex = 3;
            this.btn_Eliminarproducto.Text = "Eliminar producto";
            this.btn_Eliminarproducto.UseVisualStyleBackColor = true;
            // 
            // btn_Buscarproducto
            // 
            this.btn_Buscarproducto.Location = new System.Drawing.Point(792, 286);
            this.btn_Buscarproducto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Buscarproducto.Name = "btn_Buscarproducto";
            this.btn_Buscarproducto.Size = new System.Drawing.Size(197, 52);
            this.btn_Buscarproducto.TabIndex = 4;
            this.btn_Buscarproducto.Text = "Buscar producto";
            this.btn_Buscarproducto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del producto:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(282, 97);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio Unitario:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Construccion",
            "Equipos electricos",
            "Herramientas",
            "Equipo de seguridad"});
            this.comboBox1.Location = new System.Drawing.Point(282, 160);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Proveedor:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Stanley",
            "IBN",
            "Trupper",
            "Freund",
            "Disensa"});
            this.comboBox2.Location = new System.Drawing.Point(792, 100);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 28);
            this.comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unidad de medida:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(792, 40);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(239, 28);
            this.comboBox3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Buscarproducto);
            this.Controls.Add(this.btn_Eliminarproducto);
            this.Controls.Add(this.btn_Editarproducto);
            this.Controls.Add(this.btn_agregarproducto);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "FerreMaster";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_agregarproducto;
        private System.Windows.Forms.Button btn_Editarproducto;
        private System.Windows.Forms.Button btn_Eliminarproducto;
        private System.Windows.Forms.Button btn_Buscarproducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

