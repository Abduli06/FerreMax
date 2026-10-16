namespace FerreMax.Domain.Entities
{
    /// <summary>
    /// Entidad del catálogo general.
    /// Contiene la información base del producto independiente del inventario físico.
    /// </summary>
    public class Producto
    {
        public string SKU { get; private set; }
        public string Descripcion { get; private set; }
        public string Categoria { get; private set; }
        public string Unidad { get; private set; }
        public decimal PrecioCatalogo { get; private set; }

        public Producto(string sku, string descripcion, string categoria, string unidad, decimal precioCatalogo)
        {
            SKU = sku;
            Descripcion = descripcion;
            Categoria = categoria;
            Unidad = unidad;
            PrecioCatalogo = precioCatalogo;
        }
    }
}