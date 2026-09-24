namespace MiProyectoDeDatos.Models;

    public class Venta
    {
        public int Id;
        public DateTime Fecha;
        public Vendedor Vendedor;
        public List<Producto> ListaDeProductos;
    }
