using Entidades;
using System.Linq.Expressions;

namespace Repositorios.Interfaces
{
    public interface InterfazEstado
    {
        void Configurar(string string_conexion);
        List<Estados> Listar();
        List<Estados> Buscar(Expression<Func<Estados, bool>> condiciones);
        Estados Guardar(Estados entidad);
        Estados Modificar(Estados entidad);
        Estados Borrar(Estados entidad);
        bool Existe(Expression<Func<Estados, bool>> condiciones);
    }
}