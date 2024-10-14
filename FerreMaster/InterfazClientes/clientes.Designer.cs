namespace FerreMaster.InterfazClientes
{
    partial class clientes
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
            this.bntagregarclientes = new System.Windows.Forms.Button();
            this.bnteditarcliente = new System.Windows.Forms.Button();
            this.bnteliminarcliente = new System.Windows.Forms.Button();
            this.bntbuscarcliente = new System.Windows.Forms.Button();
            this.bnyGuardar = new System.Windows.Forms.Button();
            this.bntcancelar = new System.Windows.Forms.Button();
            this.txtagregarcliente = new System.Windows.Forms.TextBox();
            this.dtgagregarcliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgagregarcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bntagregarclientes
            // 
            this.bntagregarclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntagregarclientes.Location = new System.Drawing.Point(29, 46);
            this.bntagregarclientes.Name = "bntagregarclientes";
            this.bntagregarclientes.Size = new System.Drawing.Size(128, 23);
            this.bntagregarclientes.TabIndex = 0;
            this.bntagregarclientes.Text = "Agregar Clientes";
            this.bntagregarclientes.UseVisualStyleBackColor = true;
            // 
            // bnteditarcliente
            // 
            this.bnteditarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnteditarcliente.Location = new System.Drawing.Point(178, 46);
            this.bnteditarcliente.Name = "bnteditarcliente";
            this.bnteditarcliente.Size = new System.Drawing.Size(119, 23);
            this.bnteditarcliente.TabIndex = 1;
            this.bnteditarcliente.Text = "Editar Clientes";
            this.bnteditarcliente.UseVisualStyleBackColor = true;
            // 
            // bnteliminarcliente
            // 
            this.bnteliminarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnteliminarcliente.Location = new System.Drawing.Point(320, 46);
            this.bnteliminarcliente.Name = "bnteliminarcliente";
            this.bnteliminarcliente.Size = new System.Drawing.Size(125, 23);
            this.bnteliminarcliente.TabIndex = 2;
            this.bnteliminarcliente.Text = "Eliminar Clientes";
            this.bnteliminarcliente.UseVisualStyleBackColor = true;
            // 
            // bntbuscarcliente
            // 
            this.bntbuscarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntbuscarcliente.Location = new System.Drawing.Point(472, 46);
            this.bntbuscarcliente.Name = "bntbuscarcliente";
            this.bntbuscarcliente.Size = new System.Drawing.Size(108, 23);
            this.bntbuscarcliente.TabIndex = 3;
            this.bntbuscarcliente.Text = "Buscar Cliente";
            this.bntbuscarcliente.UseVisualStyleBackColor = true;
            // 
            // bnyGuardar
            // 
            this.bnyGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnyGuardar.Location = new System.Drawing.Point(44, 400);
            this.bnyGuardar.Name = "bnyGuardar";
            this.bnyGuardar.Size = new System.Drawing.Size(75, 23);
            this.bnyGuardar.TabIndex = 4;
            this.bnyGuardar.Text = "Guardar";
            this.bnyGuardar.UseVisualStyleBackColor = true;
            // 
            // bntcancelar
            // 
            this.bntcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcancelar.Location = new System.Drawing.Point(204, 400);
            this.bntcancelar.Name = "bntcancelar";
            this.bntcancelar.Size = new System.Drawing.Size(75, 23);
            this.bntcancelar.TabIndex = 5;
            this.bntcancelar.Text = "Cancelar";
            this.bntcancelar.UseVisualStyleBackColor = true;
            // 
            // txtagregarcliente
            // 
            this.txtagregarcliente.Location = new System.Drawing.Point(29, 104);
            this.txtagregarcliente.Multiline = true;
            this.txtagregarcliente.Name = "txtagregarcliente";
            this.txtagregarcliente.Size = new System.Drawing.Size(234, 28);
            this.txtagregarcliente.TabIndex = 6;
            // 
            // dtgagregarcliente
            // 
            this.dtgagregarcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgagregarcliente.Location = new System.Drawing.Point(29, 172);
            this.dtgagregarcliente.Name = "dtgagregarcliente";
            this.dtgagregarcliente.Size = new System.Drawing.Size(642, 186);
            this.dtgagregarcliente.TabIndex = 7;
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(722, 443);
            this.Controls.Add(this.dtgagregarcliente);
            this.Controls.Add(this.txtagregarcliente);
            this.Controls.Add(this.bntcancelar);
            this.Controls.Add(this.bnyGuardar);
            this.Controls.Add(this.bntbuscarcliente);
            this.Controls.Add(this.bnteliminarcliente);
            this.Controls.Add(this.bnteditarcliente);
            this.Controls.Add(this.bntagregarclientes);
            this.Name = "clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgagregarcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntagregarclientes;
        private System.Windows.Forms.Button bnteditarcliente;
        private System.Windows.Forms.Button bnteliminarcliente;
        private System.Windows.Forms.Button bntbuscarcliente;
        private System.Windows.Forms.Button bnyGuardar;
        private System.Windows.Forms.Button bntcancelar;
        private System.Windows.Forms.TextBox txtagregarcliente;
        private System.Windows.Forms.DataGridView dtgagregarcliente;
    }
}