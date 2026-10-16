using System;
using FerreMax.Domain.Events;

namespace FerreMax.Domain.Aggregates
{
    /// <summary>
    /// Aggregate Root crítico que controla el nivel físico de stock en una ubicación específica.
    /// Protege la invariante de evitar el sobrecompromiso de mercancía.
    /// </summary>
    public class Existencia
    {
        public string SKU { get; private set; }
        public string SucursalId { get; private set; }
        public int Cantidad { get; private set; }
        public int Minimo { get; private set; }
        public string UbicacionPasillo { get; private set; }

        public Existencia(string sku, string sucursalId, int cantidad, int minimo, string ubicacionPasillo)
        {
            SKU = sku;
            SucursalId = sucursalId;
            Cantidad = cantidad;
            Minimo = minimo;
            UbicacionPasillo = ubicacionPasillo;
        }

        public void Descontar(int cantidad)
        {
            if (Cantidad < cantidad)
                throw new InvalidOperationException("Stock insuficiente para realizar el descuento.");
                
            Cantidad -= cantidad;
        }

        public bool LlegoAlMinimo()
        {
            return Cantidad <= Minimo;
        }
    }
}