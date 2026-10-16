using System;
using System.Threading.Tasks;
using FerreMax.Domain.Repositories;

namespace FerreMax.Infrastructure.Persistence
{
    /// <summary>
    /// Implementación del patrón Unit of Work (Infraestructura).
    /// Centraliza la confirmación o reversión de transacciones asegurando la atomicidad de las operaciones.
    /// En un entorno real, encapsularía un DbContext de EF Core o un IDbTransaction.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        public Task BeginTransactionAsync()
        {
            // Iniciar transacción de base de datos
            Console.WriteLine("[Infrastructure] Iniciando transacción de BD...");
            return Task.CompletedTask;
        }

        public Task SaveChangesAsync()
        {
            // Confirmar transacción (Commit) para guardar inventario, crédito y venta al mismo tiempo
            Console.WriteLine("[Infrastructure] Haciendo Commit de los cambios en BD...");
            return Task.CompletedTask;
        }

        public Task RollbackAsync()
        {
            // Revertir en caso de excepción de dominio (Rollback) para mantener consistencia
            Console.WriteLine("[Infrastructure] Haciendo Rollback de la transacción...");
            return Task.CompletedTask;
        }
    }
}