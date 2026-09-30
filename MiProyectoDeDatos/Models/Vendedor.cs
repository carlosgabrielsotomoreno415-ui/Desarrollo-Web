namespace MiProyectoDeDatos.Models;

    public class Vendedor
    {
        public int Id;
        public string Nombres = "";
        public string Apellidos = "";

    public override string ToString()
        {
            return $"Nombre: {Nombres} {Apellidos}";
        }
    }
