using Model;

namespace Services
{
    public interface IProductoService
    {
        public IEnumerable<Producto> ObtenerProductos();
        public void CrearProducto(Producto producto)
        ;
    }
}