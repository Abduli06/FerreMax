namespace FerreMax.Domain.ValueObjects
{
    /// <summary>
    /// Value Object inmutable que asigna el factor de descuento comercial
    /// (5% para cliente regular, 10% para cliente empresarial/mayoreo).
    /// </summary>
    public abstract class PoliticaDescuento
    {
        public abstract decimal ObtenerFactorDescuento();

        public static PoliticaDescuento Crear(string tipoCliente)
        {
            return tipoCliente == "Empresarial" 
                ? new PoliticaDescuentoEmpresarial() 
                : new PoliticaDescuentoRegular();
        }
    }

    public class PoliticaDescuentoRegular : PoliticaDescuento
    {
        public override decimal ObtenerFactorDescuento() => 0.05m;
    }

    public class PoliticaDescuentoEmpresarial : PoliticaDescuento
    {
        public override decimal ObtenerFactorDescuento() => 0.10m;
    }
}