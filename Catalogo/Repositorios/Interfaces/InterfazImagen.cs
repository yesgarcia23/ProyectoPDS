using Entidades;
using System.Linq.Expressions;

namespace Repositorios.Interfaces
{
    public interface InterfazImagen
    {
        void Configurar(string string_conexion);
        List<Imagenes> Listar();
        List<Imagenes> Buscar(Expression<Func<Imagenes, bool>> condiciones);
        Imagenes Guardar(Imagenes entidad);
        Imagenes Modificar(Imagenes entidad);
        Imagenes Borrar(Imagenes entidad);
        bool Existe(Expression<Func<Imagenes, bool>> condiciones);
    }
}