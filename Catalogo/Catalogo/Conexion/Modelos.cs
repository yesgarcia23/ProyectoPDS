using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.Conexion
{
    public class Estados
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }

        [NotMapped] public virtual ICollection<Publicaciones>? Publicaciones { get; set; }
    }

    public class Categorias
    {
        [Key] public int Id { get; set; }
        public string Categoria { get; set; }

        [NotMapped] public virtual ICollection<Productos>? Productos { get; set; }
    }

    public class Fabricantes
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }

        [NotMapped] public virtual ICollection<Productos>? Productos { get; set; }
    }

    public class Imagenes
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Producto { get; set; }
        public string Archivo { get; set; }
        public string Informacion { get; set; }

        [ForeignKey("Producto")] public virtual Productos? _Producto { get; set; }
    }

    public class Productos
    {
        [Key] public int Id { get; set; }
        public string Nombre { get; set; }
        public int Fabricante { get; set; }
        public string Codigo { get; set; }
        public int Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }

        [ForeignKey("Fabricante")] public virtual Fabricantes? _Fabricante { get; set; }
        [ForeignKey("Categoria")] public virtual Categorias? _Categoria { get; set; }
        [NotMapped] public virtual ICollection<Imagenes>? Imagenes { get; set; }
        [NotMapped] public virtual ICollection<Publicaciones>? Publicaciones { get; set; }
    }

    public class Publicaciones
    {
        [Key] public int Id { get; set; }
        public int Producto { get; set; }
        public int Estado { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Titulo { get; set; }

        [ForeignKey("Producto")] public virtual Productos? _Producto { get; set; }
        [ForeignKey("Estado")] public virtual Estados? _Estado { get; set; }
    }
}