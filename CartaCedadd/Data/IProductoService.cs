using Model;

namespace Services
{
    public interface IProductoService
    {
        public IEnumerable<Producto> ObtenerProductos();
        public void CrearProducto(string nombre, decimal precio, decimal? fiesta, decimal? costo)
        ;
    }
}