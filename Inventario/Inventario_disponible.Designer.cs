namespace Inventario
{
    partial class Inventario_disponible
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
            this.salir = new System.Windows.Forms.Button();
            this.txtUnidad_de_medida = new System.Windows.Forms.DomainUpDown();
            this.txtCantidad_del_Producto = new System.Windows.Forms.NumericUpDown();
            this.txtNombre_Producto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad_del_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(351, 205);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // txtUnidad_de_medida
            // 
            this.txtUnidad_de_medida.Items.Add("Kg");
            this.txtUnidad_de_medida.Items.Add("Lts");
            this.txtUnidad_de_medida.Items.Add("gr.");
            this.txtUnidad_de_medida.Location = new System.Drawing.Point(393, 109);
            this.txtUnidad_de_medida.Name = "txtUnidad_de_medida";
            this.txtUnidad_de_medida.Size = new System.Drawing.Size(57, 20);
            this.txtUnidad_de_medida.TabIndex = 16;
            this.txtUnidad_de_medida.Text = "Kg";
            this.txtUnidad_de_medida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantidad_del_Producto
            // 
            this.txtCantidad_del_Producto.Location = new System.Drawing.Point(259, 108);
            this.txtCantidad_del_Producto.Name = "txtCantidad_del_Producto";
            this.txtCantidad_del_Producto.Size = new System.Drawing.Size(64, 20);
            this.txtCantidad_del_Producto.TabIndex = 15;
            this.txtCantidad_del_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombre_Producto
            // 
            this.txtNombre_Producto.Location = new System.Drawing.Point(28, 108);
            this.txtNombre_Producto.Name = "txtNombre_Producto";
            this.txtNombre_Producto.Size = new System.Drawing.Size(179, 20);
            this.txtNombre_Producto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Inventario_disponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUnidad_de_medida);
            this.Controls.Add(this.txtCantidad_del_Producto);
            this.Controls.Add(this.txtNombre_Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Name = "Inventario_disponible";
            this.Text = "Inventario_disponible";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad_del_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.DomainUpDown txtUnidad_de_medida;
        private System.Windows.Forms.NumericUpDown txtCantidad_del_Producto;
        private System.Windows.Forms.TextBox txtNombre_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}