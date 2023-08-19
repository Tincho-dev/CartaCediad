namespace Model;

public class Producto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal? Cost { get; set; }
    public string PhotoUrl { get; set; } = "https://i.postimg.cc/jd9Q29tV/Heineken-Rubia-Botella-1-L.webp";
    public bool Enable { get; set; } = true;
}

