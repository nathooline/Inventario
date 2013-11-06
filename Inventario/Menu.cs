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
    public partial class Menu : Form
    {
        //
        private Agregar_Invetario agregar;
        private Proovedores lista_proovedores;
        private Inventario_disponible inventario_disponible;
        private Inventario_Utilizado inventario_utilizado;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar = new Agregar_Invetario();
            agregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventario_disponible = new Inventario_disponible();
            inventario_disponible.Show();
            
        }

        private void Proovedores_Click(object sender, EventArgs e)
        {
            lista_proovedores = new Proovedores();
            lista_proovedores.Show();
        }

        private void Inventario_Utilizado_Click(object sender, EventArgs e)
        {
            inventario_utilizado = new Inventario_Utilizado();
            inventario_utilizado.Show();
        }

    }
}
