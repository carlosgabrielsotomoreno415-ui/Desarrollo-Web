namespace MiProyectoDeDatos.Models;

    public class Producto
    {
        public int Id;
        public string Nombre = "";
        public decimal PrecioDeCompra;
        public decimal PrecioDeVenta;

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Precio: {PrecioDeVenta}";
        }
    }
