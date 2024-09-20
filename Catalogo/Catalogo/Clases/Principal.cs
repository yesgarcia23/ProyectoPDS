namespace Catalogo.ConexionBasica
{
    public class Catalogo
    {
        public static void Main(string[] args)
        {
                var conEF = new ConexionEF();
                conEF.Conexion();
                Console.WriteLine("\nLISTA DE PRODUCTOS:\n");
                conEF.ObtenerProductos();
                Console.WriteLine("\nLISTA DE PUBLICACIONES:\n");
                conEF.ObtenerPublicaciones();  
        }
    }
}
