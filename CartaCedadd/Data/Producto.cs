using static System.Net.WebRequestMethods;

namespace Model;

public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public decimal? Fiesta { get; set; }
    public decimal? Costo { get; set; }
    public string PhotoUrl { get; set; }

    public Producto(string nombre, decimal precio, decimal? fiesta, decimal? costo)
    {
        Nombre = nombre;
        Precio = precio;
        Fiesta = fiesta;
        Costo = costo;
        PhotoUrl = "https://i.postimg.cc/jd9Q29tV/Heineken-Rubia-Botella-1-L.webp";
    }
    public Producto(string nombre, decimal precio, decimal? fiesta, decimal? costo, string photo)
    {
        Nombre = nombre;
        Precio = precio;
        Fiesta = fiesta;
        Costo = costo;
        PhotoUrl = photo;
    }
}

