using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

Producto producto1 = new Producto();
producto1.Nombre = "Trident";
producto1.PrecioDeCompra = 5.0m;
producto1.PrecioDeVenta = 25.9m;


var producto2 = new Producto
{
    Nombre = "Halls",
    PrecioDeCompra = 5m,
    PrecioDeVenta = 43.5m
};

var listadeProductos = new List<Producto>();
listadeProductos.Add(producto1);
listadeProductos.Add(producto2);

Console.WriteLine($"La lista contiene {listadeProductos.Count} elementos\n");
foreach (var producto in listadeProductos)
{
    Console.WriteLine($"Producto: {producto.Nombre}, Precio: {producto.PrecioDeVenta}");
}

//crear un vendedor
var vendedor1 = new Vendedor {Nombres = "Jesus", Apellidos = "Urias"};

//crear una venta de los productos antes creados
var venta1 = new Venta
{
    Fecha = new DateTime().Now,
    Vendedor = vendedor1,
    ListaDeProductos = listadeProductos
};

public class Producto
{
    public int Id;
    public string Nombre = "";
    public decimal PrecioDeCompra;
    public decimal PrecioDeVenta;
}
public class Vendedor
{
    public int Id;
    public string Nombres = "";
    public string Apellidos = "";
}

public class Venta
{
    public int Id;
    public DateTime Fecha;
    public Vendedor Vendedor;
    public List<Producto> ListaDeProductos;
}