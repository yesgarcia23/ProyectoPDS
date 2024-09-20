using Entidades;
using Repositorios.Interfaces;
using System.Linq.Expressions;

namespace Repositorios.Implementaciones
{
    public class FabricantesRepositorio : InterfazFabricante
    {
        private Conexion? conexion;

        public FabricantesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Fabricantes> Listar()
        {
            return conexion!.Listar<Fabricantes>();
        }

        public List<Fabricantes> Buscar(Expression<Func<Fabricantes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Fabricantes Guardar(Fabricantes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Fabricantes Modificar(Fabricantes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Fabricantes Borrar(Fabricantes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Fabricantes, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}