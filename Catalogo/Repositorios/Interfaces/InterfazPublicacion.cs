using Entidades;
using System.Linq.Expressions;

namespace Repositorios.Interfaces
{
    public interface InterfazPublicacion
    {
        void Configurar(string string_conexion);
        List<Publicaciones> Listar();
        List<Publicaciones> Buscar(Expression<Func<Publicaciones, bool>> condiciones);
        Publicaciones Guardar(Publicaciones entidad);
        Publicaciones Modificar(Publicaciones entidad);
        Publicaciones Borrar(Publicaciones entidad);
        bool Existe(Expression<Func<Publicaciones, bool>> condiciones);
    }
}