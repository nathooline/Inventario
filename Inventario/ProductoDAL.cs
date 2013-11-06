using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Inventario;

namespace Inventario
{
    class ProductoDAL
    {
        public static int retorno = 0;
        public static int Agregar (Producto pProducto)
        {
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando=new SqlCommand (string.Format ("Insert Into Producto (ID_de_producto, Nombre_Producto,Nombre_del_Proovedor, Empresa_del_Proovedor, Telefono, Cantidad_del_Producto, Unidad_de_medida) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", 
                    pProducto.Nombre_Producto,pProducto.Cantidad_del_Producto,pProducto.Unidad_de_medida,pProducto.Nombre_del_Proovedor,pProducto.Empresa_del_Proovedor,pProducto.Telefono),Conn);

                retorno= Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
