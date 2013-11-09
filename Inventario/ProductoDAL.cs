using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario
{
    class ProductoDAL
    {
        public static int retorno = 0;
        public static int Agregar (Producto pProducto)
        {
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Cafeteria (Nombre_Producto, Cantidad_del_Producto, Unidad_de_medida, Nombre_del_Proovedor, Empresa_del_Proovedor, Telefono) values ('" + pProducto.Nombre_Producto + "','" + pProducto.Cantidad_del_Producto + "','" + pProducto.Unidad_de_medida + "','" + pProducto.Nombre_del_Proovedor + "','" + pProducto.Empresa_del_Proovedor + "','"+pProducto.Telefono+"')"),Conn);

                retorno= Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
