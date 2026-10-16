using System.Threading.Tasks;
using FerreMax.Domain.Aggregates;
using FerreMax.Domain.Repositories;

namespace FerreMax.Infrastructure.Repositories
{
    /// <summary>
    /// Implementación del repositorio de inventario.
    /// Abstrae la persistencia del aggregate de Existencia aislando la tecnología de base de datos.
    /// </summary>
    public class InventarioRepository : IInventarioRepository
    {
        public Task<Existencia> GetExistenciaAsync(string sku, string sucursalId)
        {
            // Simulación: Retorna un objeto Existencia con stock ficticio
            return Task.FromResult(new Existencia(sku, sucursalId, 100, 10, "Pasillo 4, Estante B"));
        }

        public Task UpdateStockAsync(Existencia existencia)
        {
            // Simulación de guardado de los cambios de stock (reserva en tiempo real) en BD
            return Task.CompletedTask;
        }
    }
}