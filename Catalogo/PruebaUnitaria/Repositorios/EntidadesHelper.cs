using Entidades;

namespace PruebaUnitaria.Nucleo
{
    public class EntidadesHelper
    {
        public static Productos ObtenerPersonas()
        {
            return new Productos()
            {
                Id = 627,
                Nombre = "Jose Jose",
                Fabricante = 1,
                Codigo = "XLR8",
                Categoria = 1,
                Cantidad = 200,
                Costo = 900
            };
        }
    }
}