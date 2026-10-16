using System;
using System.Collections.Generic;
using FerreMax.Domain.Entities;

namespace FerreMax.Domain.Aggregates
{
    /// <summary>
    /// Aggregate Root transaccional central. 
    /// Agrupa los detalles de venta, asegura el cálculo correcto de totales y coordina la facturación.
    /// </summary>
    public class Venta
    {
        public string Folio { get; private set; }
        public DateTime Fecha { get; private set; }
        public string TipoPago { get; private set; }
        public decimal Descuento { get; private set; }
        public decimal Total { get; private set; }
        
        private readonly List<DetalleVenta> _detalles;
        public IReadOnlyCollection<DetalleVenta> Detalles => _detalles.AsReadOnly();

        public Venta(string folio, DateTime fecha, string tipoPago)
        {
            Folio = folio;
            Fecha = fecha;
            TipoPago = tipoPago;
            _detalles = new List<DetalleVenta>();
        }

        public void CalcularTotal()
        {
            decimal subtotal = 0;
            foreach (var detalle in _detalles)
            {
                subtotal += detalle.CalcularSubtotal();
            }
            Total = subtotal - Descuento;
        }

        public Ticket GenerarTicket()
        {
            return new Ticket(Folio, Fecha);
        }
    }
}