using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Catalogo.Conexion
{
    public class ConexionEF
    {
        private string stconexion = @"server=DESKTOP-4VE9TSQ\DEV;database=dbCatalogo;Integrated Security=True;TrustServerCertificate = true;";
        
        public void Conexion()
        {
            Console.WriteLine("Conectando a la Base de Datos....\n");

        }

        public void ObtenerProductos()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.stconexion;
            var lista_Productos = conexion.Productos
                .Include(x => x._Categoria)
                .Include(x => x._Fabricante)
                .ToList();

            foreach (var prod in lista_Productos)
            {
                Console.WriteLine(prod.Id.ToString() + " | " + 
                prod.Nombre + " | " + 
                prod._Fabricante.Id.ToString() + " | " + 
                prod.Codigo + " | " + 
                prod._Categoria.Id.ToString() + " | " + 
                prod.Precio.ToString() + " | " + 
                prod.Cantidad.ToString() + " | " + 
                prod.Costo.ToString());
            }
        }

        public void GuardarProductos()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.stconexion;

            var fabricante = new Fabricantes {Id = 0, Nombre = "", Contacto = ""};
            var categoria = new Categorias {Id = 0, Categoria = ""};
            var Producto = new Productos()
            {
                Id = 0,
                Nombre = "",
                Precio = 0.0m,
                Codigo = "",
                Cantidad = 0,
                Costo = 0.0m,
                _Fabricante = fabricante,
                _Categoria = categoria,
            };
            conexion.Productos.Add(Producto);
            conexion.SaveChanges();
        }

        public void ObtenerPublicaciones()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.stconexion;
            var lista_Publicaciones = conexion.Publicaciones
                .Include(x => x._Producto)
                .Include(x => x._Estado)
                .ToList();            
            
            foreach (var pub in lista_Publicaciones)
            {
                Console.WriteLine(
                    pub.Id.ToString() + " | " + 
                    pub.Fecha.ToString() + " | " + 
                    pub.Descripcion + " | " + 
                    pub._Producto.Id.ToString() + " | " + 
                    pub._Estado.Id.ToString());
            }
        }

        public void GuardarPublicaciones()
        {
            var conexion = new Conexion();
            conexion.StringConnection = this.stconexion;
            var producto = new Productos {Id = 0, Nombre = "", Codigo = "", Fabricante = 0, Categoria = 0, Precio = 0.0m, Cantidad = 0, Costo = 0.0m};
            var estado = new Estados {Id = 0, Nombre = ""};
            var Publicacion = new Publicaciones()
            {
                Id = 0,
                Titulo = "",
                Fecha = DateTime.Now,
                Descripcion = "",
                _Producto = producto,
                _Estado = estado,
            };
            conexion.Publicaciones.Add(Publicacion);
            conexion.SaveChanges();
        }
    }

    public partial class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Productos>? Productos { get; set; }
        public DbSet<Publicaciones>? Publicaciones { get; set; }
    } 
}