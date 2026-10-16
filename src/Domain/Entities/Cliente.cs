namespace FerreMax.Domain.Entities
{
    /// <summary>
    /// Entidad base que representa a un cliente dentro del dominio.
    /// Define la identidad y los atributos comunes para cualquier tipo de comprador.
    /// </summary>
    public class Cliente
    {
        public string CodigoCliente { get; protected set; }
        public string Nombre { get; protected set; }
        public string Tipo { get; protected set; }

        protected Cliente() { }

        public Cliente(string codigoCliente, string nombre, string tipo)
        {
            CodigoCliente = codigoCliente;
            Nombre = nombre;
            Tipo = tipo;
        }
    }
}