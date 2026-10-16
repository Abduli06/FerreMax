namespace FerreMax.Domain.ValueObjects
{
    /// <summary>
    /// Value Object inmutable y polimórfico que representa la regla de negocio
    /// de duración de una cotización dependiendo del tipo de cliente.
    /// </summary>
    public abstract class PoliticaVigencia
    {
        public abstract int ObtenerDiasVigencia();
        
        public static PoliticaVigencia Crear(string tipoCliente)
        {
            return tipoCliente == "Empresarial" 
                ? new PoliticaVigenciaEmpresarial() 
                : new PoliticaVigenciaRegular();
        }
    }

    public class PoliticaVigenciaRegular : PoliticaVigencia
    {
        public override int ObtenerDiasVigencia() => 5;
    }

    public class PoliticaVigenciaEmpresarial : PoliticaVigencia
    {
        public override int ObtenerDiasVigencia() => 3;
    }
}