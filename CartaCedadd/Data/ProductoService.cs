using Model;

namespace Services;

public class ProductoService : IProductoService
{
    private List<Producto> productos;

    public ProductoService()
    {
        productos = s_CargarProductos();
    }

    public void CrearProducto(string nombre, decimal precio, decimal? fiesta, decimal? costo)
    {
        var producto = new Producto(nombre, precio, fiesta, costo);
        productos.Add(producto);
    }

    public IEnumerable<Producto> ObtenerProductos()
    {
        return productos;
    }

    private static List<Producto> s_CargarProductos()
    {
        List<Producto> productos = new List<Producto>
    {
        new Producto("COCA 2L", 700, 560, 375),
        new Producto("PEPSI 1,25L", 400, 320, 200),
        new Producto("COCA 375ML", 300, 240, 87),
        new Producto("QUELO PALEO BN", 300, 240, 170),
        new Producto("QUELO PALEO BN X2", 550, 440, 340),
        new Producto("QUELO PALEO CAJU", 400, 320, 240),
        new Producto("QUELO PALEO CAJU X3", 1100, 880, 720),
        new Producto("TURRON", 80, 64, 35),
        new Producto("TURRON X3", 200, 160, 105),
        new Producto("EMPANADAS 12", 2200, null, 900),
        new Producto("MONSTER", 400, 320, 206),
        new Producto("CAFE", 250, 200, null),
        new Producto("HEINEKEN 1L", 1200, 960, null),
        new Producto("HEINEKEN 1L 6x5", 6000, null, null),
        new Producto("HEINEKEN 1L X4", 3840, 3072, null),
        new Producto("NORTE 1L/SALTA 1L", 800, 640, 1113),
        new Producto("NORTE 1L X4", 3000, 2400, 260),
        new Producto("QUILMES", 880, 704, 180),
        new Producto("QUILMES X4", 3200, 2560, 180),
        new Producto("HEINEKEN LATA", 500, 400, 200),
        new Producto("NORTE LATA", 400, 320, null),
        new Producto("SALTA LATA", 400, 320, 235),
        new Producto("AGUA SABORIZADA 1,5L", 420, 336, 178),
        new Producto("CEPITA FRESH 2L", 400, 320, null),
        new Producto("POWEWRADE", 500, 400, null),
        new Producto("AGUA SABORIZADA 500ML", 250, 200, 123),
        new Producto("AGUA 500ML", 200, 160, null),
        new Producto("AGUA 1,5L", 350, 280, 108)
    };

        return productos;
    }

}

