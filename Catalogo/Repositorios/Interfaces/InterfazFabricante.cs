using Entidades;
using System.Linq.Expressions;

namespace Repositorios.Interfaces
{
    public interface InterfazFabricante
    {
        void Configurar(string string_conexion);
        List<Fabricantes> Listar();
        List<Fabricantes> Buscar(Expression<Func<Fabricantes, bool>> condiciones);
        Fabricantes Guardar(Fabricantes entidad);
        Fabricantes Modificar(Fabricantes entidad);
        Fabricantes Borrar(Fabricantes entidad);
        bool Existe(Expression<Func<Fabricantes, bool>> condiciones);
    }
}