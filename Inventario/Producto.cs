using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Producto
    {
        public Int64 Id_del_producto { get; set; }
        public String Nombre_Producto { get; set; }
        public Int16 Cantidad_del_Producto { get; set; }
        public String Unidad_de_medida { get; set; }
        public String Nombre_del_Proovedor { get; set; }
        public String Empresa_del_Proovedor { get; set; }
        public Int16 Telefono { get; set; }

        public Producto() { }

        public Producto (Int64 pId_del_producto, String pNombre_Producto, Int16 pCantidad_del_Producto, String pUnidad_de_medida, String pNombre_del_Proovedor, String pEmpresa_del_Proovedor,Int16 pTelefono)
    {
        this.Id_del_producto = pId_del_producto;
        this.Nombre_Producto = Nombre_Producto;
        this.Cantidad_del_Producto=  pCantidad_del_Producto;
        this.Unidad_de_medida = pUnidad_de_medida;
        this.Nombre_del_Proovedor = pNombre_del_Proovedor;
        this.Empresa_del_Proovedor = pEmpresa_del_Proovedor;
        this.Telefono = pTelefono;
    }
    }
}
