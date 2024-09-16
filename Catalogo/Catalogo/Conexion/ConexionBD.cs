using System.Data.SqlClient;
using System.Data;

namespace Catalogo.Conexion
{
    public class ConexionBD
    {
        private string conexion = @"server=localhost;database=dbCatalogo;Integrated Security=True;TrustServerCertificate = true;";
        public void Conexion()
        {
            Console.WriteLine("Conectando a la Base de Datos....\n");

        }

        public void ObtenerProductos()
        {
            var sql = new SqlConnection(conexion);
            sql.Open();
            var consulta = "SELECT * FROM PRODUCTOS";
            var comando = new SqlCommand(consulta, sql);
            var adaptador = new SqlDataAdapter(comando);
            var data = new DataSet();
            adaptador.Fill(data);
            var lista = new List<Productos>();

            foreach(var pro in data.Tables[0].AsEnumerable())
            {
                lista.Add(new Productos()
                {
                    Id = Convert.ToInt32(pro.ItemArray[0].ToString()),
                    Nombre = pro.ItemArray[1].ToString(),
                    Precio = Convert.ToDecimal(pro.ItemArray[2].ToString()),
                    Codigo = pro.ItemArray[3].ToString(),
                    Cantidad = Convert.ToInt32(pro.ItemArray[4].ToString()),
                    Costo = Convert.ToDecimal(pro.ItemArray[5].ToString()),
                    _Fabricante = new Fabricantes
                    {
                        Id = Convert.ToInt32(pro.ItemArray[6].ToString()),
                        Nombre = pro.ItemArray[7].ToString(),
                        Contacto = pro.ItemArray[8].ToString(),
                    },
                    _Categoria = new Categorias
                    {
                        Id = Convert.ToInt32(pro.ItemArray[9].ToString()),
                        Categoria = pro.ItemArray[10].ToString(),
                    },
                }
                );
            }
            sql.Close();

            foreach(var ele in lista)
            {
                Console.WriteLine(ele.Id.ToString() + "|" + 
                ele.Nombre + "|" +
                ele.Precio.ToString() + "|" +
                ele.Codigo + "|" +
                ele.Cantidad.ToString() + "|" +
                ele.Costo.ToString() + "|" +
                ele._Fabricante.Nombre + "|" +
                ele._Categoria.Categoria);
            }
        }

        public void NonQuery()
        {
            var sql = new SqlConnection(conexion);
            sql.Open();
            var consulta = "SELECT * FROM PRODUCTOS";
            var comando = new SqlCommand(consulta, sql);
            var resultado = comando.ExecuteNonQuery();
            Console.WriteLine($"Filas afectadas: {resultado}");
            sql.Close();
        }


    }
}
