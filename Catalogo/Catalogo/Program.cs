using System;
using System.Collections.Generic;

namespace Catalogo 
{
    //Clase Estados
    public class Estados {
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
    public class Categorias {
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
    public class Fabricantes {
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
    public class Imagenes {
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
    public class Productos {
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
        public Fabricantes? Fabricante { get => this.fabricante; set => this.fabricante = value; }
        public Categorias? Categoria { get => this.categoria; set => this.categoria = value; }
        public double Precio { get => this.precio; set => this.precio = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public double Costo { get => this.costo; set => this.costo = value; }
        public List<Imagenes> Imagenes { get => this.imagenes; set => this.imagenes = value; }
        public List<Publicaciones> Publicaciones { get => this.publicaciones; set => this.publicaciones = value; }

    }

//Clase Publicaciones
    public class Publicaciones {
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