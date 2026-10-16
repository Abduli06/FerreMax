using System;
using FerreMax.Domain.ValueObjects;

namespace FerreMax.Domain.Aggregates
{
    /// <summary>
    /// Aggregate Root que gestiona el ciclo de vida de una cotización.
    /// Protege las reglas de vigencia y descuentos comerciales antes de convertirse en venta.
    /// </summary>
    public class Cotizacion
    {
        public string Folio { get; private set; }
        public DateTime FechaEmision { get; private set; }
        public int VigenciaDias { get; private set; }
        public string Estado { get; private set; }
        
        public Cotizacion(string folio, DateTime fechaEmision)
        {
            Folio = folio;
            FechaEmision = fechaEmision;
            Estado = "Generada";
        }

        public bool EstaVigente(DateTime fechaActual)
        {
            return (fechaActual - FechaEmision).TotalDays <= VigenciaDias;
        }

        public void AplicarPolitica(PoliticaVigencia vigencia, PoliticaDescuento descuento)
        {
            VigenciaDias = vigencia.ObtenerDiasVigencia();
            // Lógica interna para aplicar el porcentaje de descuento a los montos de la cotización
        }
    }
}