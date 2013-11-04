namespace WindowsFormsApplication1
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Agregar_Inventario = new System.Windows.Forms.Button();
            this.Inventario_Disponible = new System.Windows.Forms.Button();
            this.Proovedores = new System.Windows.Forms.Button();
            this.Inventario_Utilizado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agregar_Inventario
            // 
            this.Agregar_Inventario.Location = new System.Drawing.Point(30, 24);
            this.Agregar_Inventario.Name = "Agregar_Inventario";
            this.Agregar_Inventario.Size = new System.Drawing.Size(75, 51);
            this.Agregar_Inventario.TabIndex = 0;
            this.Agregar_Inventario.Text = "Agregar Inventario";
            this.Agregar_Inventario.UseVisualStyleBackColor = true;
            this.Agregar_Inventario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventario_Disponible
            // 
            this.Inventario_Disponible.Location = new System.Drawing.Point(353, 24);
            this.Inventario_Disponible.Name = "Inventario_Disponible";
            this.Inventario_Disponible.Size = new System.Drawing.Size(75, 51);
            this.Inventario_Disponible.TabIndex = 1;
            this.Inventario_Disponible.Text = "Inventario Disponible";
            this.Inventario_Disponible.UseVisualStyleBackColor = true;
            this.Inventario_Disponible.Click += new System.EventHandler(this.button2_Click);
            // 
            // Proovedores
            // 
            this.Proovedores.Location = new System.Drawing.Point(30, 170);
            this.Proovedores.Name = "Proovedores";
            this.Proovedores.Size = new System.Drawing.Size(75, 51);
            this.Proovedores.TabIndex = 2;
            this.Proovedores.Text = "Lista de Proovedores";
            this.Proovedores.UseVisualStyleBackColor = true;
            this.Proovedores.Click += new System.EventHandler(this.Proovedores_Click);
            // 
            // Inventario_Utilizado
            // 
            this.Inventario_Utilizado.Location = new System.Drawing.Point(353, 170);
            this.Inventario_Utilizado.Name = "Inventario_Utilizado";
            this.Inventario_Utilizado.Size = new System.Drawing.Size(75, 51);
            this.Inventario_Utilizado.TabIndex = 3;
            this.Inventario_Utilizado.Text = "Inventario Utilizado Hoy";
            this.Inventario_Utilizado.UseVisualStyleBackColor = true;
            this.Inventario_Utilizado.Click += new System.EventHandler(this.Inventario_Utilizado_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.Inventario_Utilizado);
            this.Controls.Add(this.Proovedores);
            this.Controls.Add(this.Inventario_Disponible);
            this.Controls.Add(this.Agregar_Inventario);
            this.Name = "Menu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Agregar_Inventario;
        private System.Windows.Forms.Button Inventario_Disponible;
        private System.Windows.Forms.Button Proovedores;
        private System.Windows.Forms.Button Inventario_Utilizado;
    }
}

