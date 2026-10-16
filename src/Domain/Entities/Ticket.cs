using System;

namespace FerreMax.Domain.Entities
{
    /// <summary>
    /// Entidad que representa el comprobante físico/digital de una Venta.
    /// Útil para la validación posterior en casos de devoluciones.
    /// </summary>
    public class Ticket
    {
        public string Numero { get; private set; }
        public DateTime Fecha { get; private set; }

        public Ticket(string numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public void Imprimir()
        {
            // Lógica de dominio para dar formato de impresión al ticket
        }
    }
}