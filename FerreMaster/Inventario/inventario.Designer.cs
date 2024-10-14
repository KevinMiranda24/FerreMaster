namespace FerreMaster.Inventario
{
    partial class inventario
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbBuscarproducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bntNuevaentrada = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtgInventari = new System.Windows.Forms.DataGridView();
            this.bntNuevasalida = new System.Windows.Forms.Button();
            this.bntVerproducto = new System.Windows.Forms.Button();
            this.bntguardar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventari)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // lbBuscarproducto
            // 
            this.lbBuscarproducto.AutoSize = true;
            this.lbBuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarproducto.Location = new System.Drawing.Point(280, 19);
            this.lbBuscarproducto.Name = "lbBuscarproducto";
            this.lbBuscarproducto.Size = new System.Drawing.Size(120, 16);
            this.lbBuscarproducto.TabIndex = 1;
            this.lbBuscarproducto.Text = "Buscar producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // bntNuevaentrada
            // 
            this.bntNuevaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNuevaentrada.Location = new System.Drawing.Point(22, 70);
            this.bntNuevaentrada.Name = "bntNuevaentrada";
            this.bntNuevaentrada.Size = new System.Drawing.Size(113, 33);
            this.bntNuevaentrada.TabIndex = 3;
            this.bntNuevaentrada.Text = "Nueva entrada";
            this.bntNuevaentrada.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 129);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // dtgInventari
            // 
            this.dtgInventari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventari.Location = new System.Drawing.Point(22, 216);
            this.dtgInventari.Name = "dtgInventari";
            this.dtgInventari.Size = new System.Drawing.Size(690, 202);
            this.dtgInventari.TabIndex = 5;
            // 
            // bntNuevasalida
            // 
            this.bntNuevasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNuevasalida.Location = new System.Drawing.Point(295, 70);
            this.bntNuevasalida.Name = "bntNuevasalida";
            this.bntNuevasalida.Size = new System.Drawing.Size(112, 33);
            this.bntNuevasalida.TabIndex = 6;
            this.bntNuevasalida.Text = "Nueva salida";
            this.bntNuevasalida.UseVisualStyleBackColor = true;
            // 
            // bntVerproducto
            // 
            this.bntVerproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVerproducto.Location = new System.Drawing.Point(532, 70);
            this.bntVerproducto.Name = "bntVerproducto";
            this.bntVerproducto.Size = new System.Drawing.Size(108, 33);
            this.bntVerproducto.TabIndex = 7;
            this.bntVerproducto.Text = "Ver producto";
            this.bntVerproducto.UseVisualStyleBackColor = true;
            // 
            // bntguardar
            // 
            this.bntguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntguardar.Location = new System.Drawing.Point(22, 175);
            this.bntguardar.Name = "bntguardar";
            this.bntguardar.Size = new System.Drawing.Size(94, 23);
            this.bntguardar.TabIndex = 8;
            this.bntguardar.Text = "Guardar";
            this.bntguardar.UseVisualStyleBackColor = true;
            // 
            // bntCancelar
            // 
            this.bntCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCancelar.Location = new System.Drawing.Point(184, 175);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(100, 23);
            this.bntCancelar.TabIndex = 9;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad:";
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(732, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntguardar);
            this.Controls.Add(this.bntVerproducto);
            this.Controls.Add(this.bntNuevasalida);
            this.Controls.Add(this.dtgInventari);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bntNuevaentrada);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbBuscarproducto);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbBuscarproducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bntNuevaentrada;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dtgInventari;
        private System.Windows.Forms.Button bntNuevasalida;
        private System.Windows.Forms.Button bntVerproducto;
        private System.Windows.Forms.Button bntguardar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Label label2;
    }
}