using System;
using System.Collections.Generic;
using System.Linq;
using MiProyectoDeDatos.Models;
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
var vendedor1 = new Vendedor { Nombres = "Jesus", Apellidos = "Urias" };
var vendedor2 = new Vendedor { Nombres = "Juan", Apellidos = "Perez" };

//crear una venta de los productos antes creados
var venta1 = new Venta
{
    Fecha = DateTime.Now,
    Vendedor = vendedor1,
};
venta1.ListaDeProductos = new List<VentaProducto>
{
    new VentaProducto
    {
        Venta = venta1,
        Producto = producto1,
        Cantidad = 2,
        Subtotal = 2 * producto1.PrecioDeVenta
    }

};
var venta2 = new Venta
{
    Fecha = DateTime.Now,
    Vendedor = vendedor2,
};
venta2.ListaDeProductos = new List<VentaProducto>
{
    new VentaProducto
    {
        Venta = venta2,
        Producto = producto2,
        Cantidad = 1,
        Subtotal = 1 * producto2.PrecioDeVenta
    }
};

venta1.ImprimirTicket();

//EJERCICIO LINQ
var alumnos = new List<Alumno>
{
    new Alumno {Nombre="Ana", Materia="Programacion", Calificacion=95},
    new Alumno {Nombre="Luis", Materia="Programacion", Calificacion=52},
    new Alumno {Nombre="Sofia", Materia="Base de Datos", Calificacion=88},
    new Alumno {Nombre="Ivan", Materia="Base de Datos", Calificacion=70},
};

//var aprobados = new List<Alumno>();
//foreach (var a in alumnos)
//{
    //if (a.Calificacion >= 70)
   // {
   //    aprobados.Add(a);
   // }
//}
//LINQ: FILTRAR (where)
var aprobados = alumnos.Where(a => a.Calificacion >= 70);
//SELECT * FROM alumnos WHERE Calificacion >= 70;

//LINQ: Transformar (Select)
var nombres = alumnos.Select(a => a.Nombre);
//SELECT Nombre FROM alumnos;

//obtener los nombres de los alumnos aprobados
var nombresAprobados = alumnos
    .Where(a => a.Calificacion >= 70)
    .Select(a => a.Nombre);

//LINQ: Count, Sum, Average
int total = alumnos.Count();
int aprobadosN = alumnos.Count(a => a.Calificacion >= 70);
double promedio = (double)alumnos.Average(a => a.Calificacion);
double sumatoria = (double)alumnos.Sum(a => a.Calificacion);

//LINQ Orderby
var ordenados = alumnos
    .OrderBy(a => a.Calificacion)
    .ThenBy(a => a.Nombre);

//LINQ: GroupBy
var porMateria = alumnos
    .GroupBy(a => a.Materia)
    .Select(grupo => new
    {
        Materia = grupo.Key,
        Promedio = grupo.Average(g => g.Calificacion),
        Cantidad = grupo.Count()
    });

//SELECT Materia, Average(Calificacion) Promedio, Count(Nombre) Total 
// FROM alumnos GROUP BY Materia;