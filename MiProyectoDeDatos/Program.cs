using System.Security.Authentication;

Console.WriteLine("Hello, World!");

Producto producto1 = new Producto();
producto1.Nombre = "Trident";
producto1.PrecioDeCompra = 5.0m;
producto1.PrecioDeVenta = 25.9m;

//asignacion de tipo por inferencia
var producto2 = new Producto
{
    Nombre = "",
    PrecioDeCompra = 5m,
    PrecioDeVenta = 43.5m
};

var listadeProductos = new List<Producto>();
listadeProductos.Add(producto1);
listadeProductos.Add(producto2);

Console.WriteLine($"La lista contiene {listadeProductos.Count} elementos");

public class Producto
{
    public int Id;
    public string Nombre;
    public decimal PrecioDeCompra;
    public decimal PrecioDeVenta;
}