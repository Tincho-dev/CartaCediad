using Model;
using static System.Net.WebRequestMethods;

namespace Services
{
    public class ProductoService : IProductoService
    {
        private List<Producto> productos;

        public ProductoService()
        {
            productos = s_CargarProductos();
        }

        public void CrearProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public IEnumerable<Producto> ObtenerProductos()
        {
            return productos;
        }

        private static List<Producto> s_CargarProductos()
        {
            return new List<Producto>
            {
                new Producto{Name = "COCA 2L", Price = 700, Cost = 375, PhotoUrl="https://i.postimg.cc/fLSbMPD1/Coca-Comun-2-L.png\r\n"},
                new Producto{Name = "SPRITE 2L", Price = 700, Cost = 375, PhotoUrl="https://i.postimg.cc/BQTX8RH0/Sprite-2-L.png\r\n"},
                new Producto{Name = "FANTA 2L", Price = 700, Cost = 375, PhotoUrl="https://i.postimg.cc/VN66V6Tf/Fanta-2L.png\r\n"},
                new Producto{Name = "COCA ZERO 2L", Price = 700, Cost = 375, PhotoUrl="https://i.postimg.cc/sgKxmSTH/Coca-Zero-2-L.png\r\n"},
                new Producto{Name = "PEPSI 1,25L", Price = 400, Cost = 200, PhotoUrl="https://i.postimg.cc/J4VszRyx/Pepsi-Comun-1-25-L.jpg\r\n"},
                new Producto{Name = "COCA 375ML", Price = 300, Cost = 87, PhotoUrl="https://i.postimg.cc/wBGv8z8h/Coca-Comun-375ml.png\r\n"},
                new Producto{Name = "FANTA 375ML", Price = 300, Cost = 87, PhotoUrl="https://i.postimg.cc/sfZBzM21/Fanta-375ml.png\r\n"},
                new Producto{Name = "SPRITE 375ML", Price = 300, Cost = 87, PhotoUrl="https://i.postimg.cc/cLd6fTB8/Sprite-375ml.png\r\n"},
                new Producto{Name = "COCA ZERO 375ML", Price = 300, Cost = 87, PhotoUrl="https://i.postimg.cc/gj92jK0j/Coca-Zero-375ml.png\r\n"},
                new Producto{Name = "QUELO PALEO BLANCO", Price = 300, Cost = 170, PhotoUrl="https://i.postimg.cc/fLQbTKyL/Quelo-Paleo-Blanco-50g.png\r\n"},
                new Producto{Name = "QUELO PALEO NEGRO", Price = 300, Cost = 170, PhotoUrl="https://i.postimg.cc/Twj3yD5c/Quelo-Paleo-Negro-50g.png\r\n"},
                new Producto{Name = "QUELO PALEO BN X2", Price = 550, Cost = 340, PhotoUrl="https://i.postimg.cc/Twj3yD5c/Quelo-Paleo-Negro-50g.png"},
                new Producto{Name = "QUELO PALEO CAJU", Price = 400, Cost = 240, PhotoUrl="https://i.postimg.cc/8z35xDVL/Quelo-Paleo-Caju-50g.png\r\n"},
                new Producto{Name = "QUELO PALEO CAJU X3", Price = 1100, Cost = 720, PhotoUrl="https://i.postimg.cc/8z35xDVL/Quelo-Paleo-Caju-50g.png\r\n"},
                new Producto{Name = "TURRON", Price = 80, Cost = 35, PhotoUrl="https://i.postimg.cc/SxQTHFGQ/Turron-Misky.jpg\r\n"},
                new Producto{Name = "TURRON X3", Price = 200, Cost = 105, PhotoUrl="https://i.postimg.cc/CKzvLGtW/Turron-Misky-X3.jpg\r\n"},
                new Producto{Name = "EMPANADAS 12", Price = 2200, Cost = 900, PhotoUrl="https://i.postimg.cc/1zhgfPYs/EMPANADAS-Y-NORTE.jpg\r\n"},
                new Producto{Name = "MONSTER ROSSI", Price = 400, Cost = 206, PhotoUrl="https://i.postimg.cc/L47s02BR/Monster-Rossi-473ml.png\r\n"},
                new Producto{Name = "MONSTER ULTRA WATERMELON", Price = 400, Cost = 206, PhotoUrl="https://i.postimg.cc/pXFLw4qj/Monster-Ultra-Watermelon-473ml.jpg\r\n"},
                new Producto{Name = "REDBULL", Price = 400, Cost = 206, PhotoUrl="https://i.postimg.cc/L8F82Dbb/Redbull-250ml.png\r\n"},
                new Producto{Name = "CAFE", Price = 250, Cost = null, PhotoUrl="https://st.depositphotos.com/1020804/1337/i/450/depositphotos_13376488-stock-photo-coffee-cup-and-beans.jpg"},
                new Producto{Name = "HEINEKEN 1L", Price = 1200, Cost = null},
                new Producto{Name = "HEINEKEN 1L 6x5", Price = 6000, Cost = null},
                new Producto{Name = "HEINEKEN 1L X4", Price = 3840, Cost = null},
                new Producto{Name = "NORTE 1L/SALTA 1L", Price = 800, Cost = 1113, PhotoUrl="https://i.postimg.cc/6pZ4hTDD/Norte-Rubia-Botella-1-L.jpg\r\n"},
                new Producto{Name = "NORTE 1L X4", Price = 3000, Cost = 260, PhotoUrl="https://i.postimg.cc/6pZ4hTDD/Norte-Rubia-Botella-1-L.jpg\r\n"},
                new Producto{Name = "QUILMES", Price = 880, Cost = 180, PhotoUrl="https://masonlineprod.vtexassets.com/arquivos/ids/155586/Cerveza-Clasica-Quilmes-Retornable-1-Lt-2-548.jpg?v=637835119806900000"},
                new Producto{Name = "QUILMES X4", Price = 3200, Cost = 180, PhotoUrl="https://masonlineprod.vtexassets.com/arquivos/ids/155586/Cerveza-Clasica-Quilmes-Retornable-1-Lt-2-548.jpg?v=637835119806900000"},
                new Producto{Name = "HEINEKEN LATA", Price = 500, Cost = 200},
                new Producto{Name = "NORTE LATA", Price = 400, Cost = null, PhotoUrl="https://i.postimg.cc/SK7Xw3Qd/Norte-Rubia-Lata-473ml.png\r\n"},
                new Producto{Name = "SALTA LATA", Price = 400, Cost = 235, PhotoUrl="https://i.postimg.cc/zf1b28N3/Salta-Negra-Lata-473ml.png\r\n"},
                new Producto{Name = "AGUA SABORIZADA 1,5L MANZANA", Price = 420, Cost = 178, PhotoUrl="https://i.postimg.cc/KvgN3cvH/Fresh-Manzana-1-5-L.png\r\n"},
                new Producto{Name = "AGUA SABORIZADA 1,5L NARANJA", Price = 420, Cost = 178, PhotoUrl="https://i.postimg.cc/Hxx0Ydh3/Vida-Naranja-1-5-L.png\r\n"},
                new Producto{Name = "AGUA SABORIZADA 1,5L POMELO", Price = 420, Cost = 178, PhotoUrl="https://i.postimg.cc/ydbmW2qK/Vida-Pomelo-1-5-L.png\r\n"},
                new Producto{Name = "CEPITA FRESH 2L", Price = 400, Cost = null, Enable = false},
                new Producto{Name = "POWEWRADE", Price = 500, Cost = null, PhotoUrl="https://i.postimg.cc/dV2jnWCR/Power-Ade-Mundial-500ml.jpg\r\n"},
                new Producto{Name = "AGUA SABORIZADA 500ML", Price = 250, Cost = 123, PhotoUrl="https://statics.dinoonline.com.ar/imagenes/full_600x600_ma/3040016_f.jpg"},
                new Producto{Name = "Soda 500ml", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/3N0gG97v/Palau-Agua-500ml.png\r\n"},
                new Producto{Name = "ADES 1L DURAZNO", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/Nf9kWs3x/Ade-S-Durazno-1-L.jpg\r\n"},
                new Producto{Name = "CEPITA 1,5L DURAZNO", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/nzhvTpKB/Cepita-Durazno-Botella-1-5-L.png\r\n"},
                new Producto{Name = "CEPITA 1,5L MANZANA", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/hGg8z9fC/Cepita-Manzana-Botella-1-5-L.png\r\n"},
                new Producto{Name = "CEPITA 1L NARANJA", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/k5cQxBS7/Cepita-Naranja-Carton-1-L.png\r\n"},
                new Producto{Name = "ADES 1L MANZANA", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/7YFnDvDr/Ade-S-Manzana-1-L.jpg\r\n"},
                new Producto{Name = "ADES 200ML FRUTILLA", Price=0, Cost= null, Enable= false, PhotoUrl="https://i.postimg.cc/13Dc3W5n/Ades-Frutilla-200ml.png\r\n"},
                new Producto{Name = "AGUA 500ML", Price = 200, Cost = null, PhotoUrl="https://i.postimg.cc/3N0gG97v/Palau-Agua-500ml.png\r\n"},
                new Producto{Name = "AGUA 1,5L", Price = 350, Cost = 108, PhotoUrl="https://i.postimg.cc/7LqMRg1F/Palau-2L.png\r\n"}
            };
        }
    }
}
