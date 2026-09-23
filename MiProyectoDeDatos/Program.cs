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
    Fecha = DateTime.Now,
    Vendedor = vendedor1,
    ListaDeProductos = listadeProductos
};


// Parte 1


// Crear al menos dos vendedores diferentes
var vendedor2 = new Vendedor { Nombres = "Maria", Apellidos = "Gomez" };

// Crear productos adicionales para completar las distintas ventas
var producto3 = new Producto { Nombre = "Carlos V", PrecioDeCompra = 10m, PrecioDeVenta = 20m };
var producto4 = new Producto { Nombre = "Galletas Emperador", PrecioDeCompra = 12m, PrecioDeVenta = 18.5m };

// Declarar al menos tres ventas con dos o más productos cada una y repartidas entre los vendedores
var venta2 = new Venta
{
    Fecha = DateTime.Now.AddDays(-1),
    Vendedor = vendedor1,
    ListaDeProductos = new List<Producto> { producto2, producto3 }
};

var venta3 = new Venta
{
    Fecha = DateTime.Now.AddDays(-2),
    Vendedor = vendedor2,
    ListaDeProductos = new List<Producto> { producto1, producto3, producto4 }
};

// Crear lista global de ventas
var listaDeVentas = new List<Venta> { venta1, venta2, venta3 };

// Recorrer la lista de ventas e imprimir información requerida
Console.WriteLine("\n--- RESUMEN DE VENTAS ---");
foreach (var venta in listaDeVentas)
{
    Console.WriteLine($"\nVendedor: {venta.Vendedor.Nombres} {venta.Vendedor.Apellidos}");
    Console.WriteLine($"Fecha: {venta.Fecha}");
    Console.WriteLine("Productos:");
    foreach (var prod in venta.ListaDeProductos)
    {
        Console.WriteLine($" - {prod.Nombre}: ${prod.PrecioDeVenta}");
    }
}

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

