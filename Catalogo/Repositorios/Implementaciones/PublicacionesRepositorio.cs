using Entidades;
using Repositorios.Interfaces;
using System.Linq.Expressions;

namespace Repositorios.Implementaciones
{
    public class PublicacionesRepositorio : InterfazPublicacion
    {
        private Conexion? conexion;

        public PublicacionesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Publicaciones> Listar()
        {
            return conexion!.Listar<Publicaciones>();
        }

        public List<Publicaciones> Buscar(Expression<Func<Publicaciones, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Publicaciones Guardar(Publicaciones entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Publicaciones Modificar(Publicaciones entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Publicaciones Borrar(Publicaciones entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Publicaciones, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}