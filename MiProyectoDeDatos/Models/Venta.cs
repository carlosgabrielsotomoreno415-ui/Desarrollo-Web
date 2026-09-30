namespace MiProyectoDeDatos.Models;

    public class Venta
    {
        public int Id;
        public DateTime Fecha;
        public Vendedor Vendedor;
        public List<VentaProducto> ListaDeProductos;

        public void ImprimirTicket()
        {
            decimal total = 0;
            System.Console.WriteLine("Ticket de Venta");
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine($"Fecha: {Fecha}");
            System.Console.WriteLine($"Vendedor: {Vendedor}");
            System.Console.WriteLine("--------------------------------");
            // recorrido de la lista de productos
            foreach (var vp in ListaDeProductos)
            {
                System.Console.WriteLine($"{vp.Producto.Nombre} {vp.Cantidad} {vp.Producto.PrecioDeVenta} {vp.Subtotal}");
                total += vp.Subtotal;
            }
            System.Console.WriteLine("--------------------------------");
            System.Console.WriteLine($"Total: {total}");

        }
    }
