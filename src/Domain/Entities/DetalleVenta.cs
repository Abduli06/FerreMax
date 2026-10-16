namespace FerreMax.Domain.Entities
{
    /// <summary>
    /// Entidad hija del Aggregate Venta. 
    /// Representa un concepto individual dentro de una transacción.
    /// </summary>
    public class DetalleVenta
    {
        public string SKU { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioUnitario { get; private set; }

        public DetalleVenta(string sku, int cantidad, decimal precioUnitario)
        {
            SKU = sku;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        public decimal CalcularSubtotal()
        {
            return Cantidad * PrecioUnitario;
        }
    }
}