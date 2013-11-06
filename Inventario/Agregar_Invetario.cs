using Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Agregar_Invetario : Form
    {
        public Agregar_Invetario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto();
            Producto.Nombre_Producto = txtNombre_Producto.Text;
            Producto.Cantidad_del_Producto = txtCantidad_del_Producto.Text;
            Producto.Unidad_de_medida = txtUnidad_de_medida.Text;
            Producto.Nombre_del_Proovedor = txtNombre_del_Proovedor.Text;
            Producto.Empresa_del_Proovedor = txtEmpresa_del_proovedor.Text;
            Producto.Telefono = txtTelefono.Text;

            int resultado = ProductoDAL.Agregar(Producto);
            if (resultado >0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Guardaron los Datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
