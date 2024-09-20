using Entidades;
using Repositorios.Interfaces;
using System.Linq.Expressions;

namespace Repositorios.Implementaciones
{
    public class EstadosRepositorio : InterfazEstado
    {
        private Conexion? conexion;

        public EstadosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Estados> Listar()
        {
            return conexion!.Listar<Estados>();
        }

        public List<Estados> Buscar(Expression<Func<Estados, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Estados Guardar(Estados entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Estados Modificar(Estados entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Estados Borrar(Estados entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Estados, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}