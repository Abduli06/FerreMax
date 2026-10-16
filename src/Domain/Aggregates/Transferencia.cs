using System;

namespace FerreMax.Domain.Aggregates
{
    /// <summary>
    /// Aggregate Root que gestiona el traslado de mercancía entre sucursales.
    /// Controla la transición de estado temporal para evitar ventas de mercancía "En tránsito".
    /// </summary>
    public class Transferencia
    {
        public DateTime Fecha { get; private set; }
        public string SKU { get; private set; }
        public string SucursalOrigen { get; private set; }
        public string SucursalDestino { get; private set; }
        public int Cantidad { get; private set; }
        public string Estado { get; private set; }

        public Transferencia(string sku, string sucursalOrigen, string sucursalDestino, int cantidad)
        {
            Fecha = DateTime.UtcNow;
            SKU = sku;
            SucursalOrigen = sucursalOrigen;
            SucursalDestino = sucursalDestino;
            Cantidad = cantidad;
            Estado = "Creada";
        }

        public void MarcarEnTransito()
        {
            Estado = "En tránsito";
        }

        public void ConfirmarRecepcion()
        {
            Estado = "Confirmado";
        }
    }
}