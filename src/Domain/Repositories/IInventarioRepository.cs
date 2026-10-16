using System.Threading.Tasks;
using FerreMax.Domain.Aggregates;

namespace FerreMax.Domain.Repositories
{
    /// <summary>
    /// Contrato de repositorio para orquestar persistencia de existencias sin dependencias SQL.
    /// </summary>
    public interface IInventarioRepository
    {
        Task<Existencia> GetExistenciaAsync(string sku, string sucursalId);
        Task UpdateStockAsync(Existencia existencia);
    }
}