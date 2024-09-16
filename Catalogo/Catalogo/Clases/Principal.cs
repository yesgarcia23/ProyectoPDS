using System;

namespace Catalogo.Conexion
{
    public class Catalogo
    {
        public static void Main(string[] args)
        {
            /*var estado = new Estados { Id = 1, Nombre = "Disponible" };
            var categoria = new Categorias { Id = 1, Categoria = "Electrónica" };
            var fabricante = new Fabricantes { Id = 1, Nombre = "Samsung", Contacto = "contacto@samsung.com" };
            var producto = new Productos
            {
                Id = 1,
                Nombre = "Televisor 4K",
                Fabricante = fabricante,
                Categoria = categoria,
                Precio = 800000,
                Cantidad = 50,
                Costo = 650000
            };
            var imagen = new Imagenes
            {
                Id = 1,
                Producto = producto,
                Archivo = "televisor4k.jpg",
                Informacion = "Imagen del Televisor 4K"
            };
            var publicacion = new Publicaciones
            {
                Id = 1,
                Producto = producto,
                Estado = estado,
                Fecha = DateTime.Now,
                Descripcion = "Nuevo televisor 4K en stock."
            };

            producto.Imagenes.Add(imagen);
            producto.Publicaciones.Add(publicacion);

            Console.WriteLine("Información del Producto:");
            Console.WriteLine($"ID: {producto.Id}");
            Console.WriteLine($"Nombre: {producto.Nombre}"); 
            Console.WriteLine($"Fabricante: {producto.Fabricante?.Nombre}");
            Console.WriteLine($"Categoría: {producto.Categoria?.Categoria}");
            Console.WriteLine($"Precio: {producto.Precio}");
            Console.WriteLine($"Cantidad: {producto.Cantidad}");
            Console.WriteLine($"Costo: {producto.Costo}");

            Console.WriteLine("\nImágenes del Producto:");
            foreach (var img in producto.Imagenes)
            {
                Console.WriteLine($"- Archivo: {img.Archivo}, Información: {img.Informacion}");
            }

            Console.WriteLine("\nPublicaciones del Producto:");
            foreach (var pub in producto.Publicaciones)
            {
                Console.WriteLine($"- Descripción: {pub.Descripcion}, Fecha: {pub.Fecha}");
            }*/
                var conEF = new ConexionEF();
                conEF.Conexion();
                Console.WriteLine("\nLISTA DE PRODUCTOS:\n");
                conEF.ObtenerProductos();
                Console.WriteLine("\nLISTA DE PUBLICACIONES:\n");
                conEF.ObtenerPublicaciones();  
        }
    }
}
