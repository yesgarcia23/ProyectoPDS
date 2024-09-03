using System;
using System.Collections.Generic;

namespace Catalogo.Program
{
//Clase Programa
    class Program 
    {
        //Metodo Principal
        private static void Main(string[] args)
        {
            var estado = new Estados { Id = 1, Nombre = "Disponible" };
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
            }
        }
    }

//Clase Estados
    public class Estados 
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private List<Publicaciones> publicaciones = new List<Publicaciones>();

        //Propiedades
         public int Id { get => this.id; set => this.id = value; }
         public string Nombre { get => this.nombre; set => this.nombre = value; }
         public List<Publicaciones> Publicaciones { get => this.publicaciones; set => this.publicaciones = value; }
         
    }

//Clase Categorias
    public class Categorias 
    {
        //Atributos
        private int id = 0;
        private string categoria = "";
        private List<Productos> productos = new List<Productos>();

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Categoria { get => this.categoria; set => this.categoria = value; }
        public List<Productos> Productos { get => this.productos; set => this.productos = value; }
    }

//Clase Fabricantes
    public class Fabricantes 
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private string contacto = "";
        private List<Productos> productos = new List<Productos>();

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Contacto { get => this.contacto; set => this.contacto = value; }
        public List<Productos> Productos { get => this.productos; set => this.productos = value; }

    }

//Clase Imagenes
    public class Imagenes 
    {
        //Atributos
        private int id = 0;
        private Productos? producto = null;
        private string archivo = "";
        private string informacion = "";

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        public string Archivo { get => this.archivo; set => this.archivo = value; }
        public string Informacion { get => this.informacion; set => this.informacion = value; }
    }

//Clase Productos
    public class Productos 
    {
        //Atributos
        private int id = 0;
        private string nombre = "";
        private Fabricantes? fabricante = null;
        private Categorias? categoria= null;
        private double precio = 0.0;
        private int cantidad = 0;
        private double costo = 0;
        private List<Imagenes> imagenes = new List<Imagenes>();
        private List<Publicaciones> publicaciones = new List<Publicaciones>();

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public Fabricantes? Fabricante { get => this.fabricante; set => this.fabricante = value; }
        public Categorias? Categoria { get => this.categoria; set => this.categoria = value; }
        public double Precio { get => this.precio; set => this.precio = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public double Costo { get => this.costo; set => this.costo = value; }
        public List<Imagenes> Imagenes { get => this.imagenes; set => this.imagenes = value; }
        public List<Publicaciones> Publicaciones { get => this.publicaciones; set => this.publicaciones = value; }

    }

//Clase Publicaciones
    public class Publicaciones 
    {
        //Atributos
        private int id = 0;
        private Productos? producto = null;
        private Estados? estado = null;
        private DateTime? fecha = null;
        private string descripcion = "";

        //Propiedades
        public int Id { get => this.id; set => this.id = value; }
        public Productos? Producto { get => this.producto; set => this.producto = value; }
        public Estados? Estado { get => this.estado; set => this.estado = value; }
        public DateTime? Fecha { get => this.fecha; set => this.fecha = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
    }
}