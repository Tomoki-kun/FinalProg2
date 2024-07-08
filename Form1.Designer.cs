namespace SpeerdrunFinalProg2
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.leerDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.btnExpPedidos = new System.Windows.Forms.Button();
            this.btnExpCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(88, 281);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(129, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbProductos);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExpPedidos);
            this.groupBox2.Controls.Add(this.btnExpCliente);
            this.groupBox2.Controls.Add(this.btnImportar);
            this.groupBox2.Location = new System.Drawing.Point(541, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 426);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // leerDialog
            // 
            this.leerDialog.FileName = "productos.csv";
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.ItemHeight = 16;
            this.lbProductos.Location = new System.Drawing.Point(293, 255);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(173, 180);
            this.lbProductos.TabIndex = 1;
            // 
            // btnExpPedidos
            // 
            this.btnExpPedidos.Location = new System.Drawing.Point(88, 92);
            this.btnExpPedidos.Name = "btnExpPedidos";
            this.btnExpPedidos.Size = new System.Drawing.Size(129, 23);
            this.btnExpPedidos.TabIndex = 2;
            this.btnExpPedidos.Text = "Exportar Pedidos";
            this.btnExpPedidos.UseVisualStyleBackColor = true;
            this.btnExpPedidos.Click += new System.EventHandler(this.btnExpPedidos_Click);
            // 
            // btnExpCliente
            // 
            this.btnExpCliente.Location = new System.Drawing.Point(88, 51);
            this.btnExpCliente.Name = "btnExpCliente";
            this.btnExpCliente.Size = new System.Drawing.Size(129, 23);
            this.btnExpCliente.TabIndex = 3;
            this.btnExpCliente.Text = "Exportar Cliente";
            this.btnExpCliente.UseVisualStyleBackColor = true;
            this.btnExpCliente.Click += new System.EventHandler(this.btnExpCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog leerDialog;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Button btnExpPedidos;
        private System.Windows.Forms.Button btnExpCliente;
    }
}

