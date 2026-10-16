using System;
using System.Threading.Tasks;
using FerreMax.Domain.Repositories;

namespace FerreMax.Application.Services
{
    /// <summary>
    /// Servicio de aplicación que coordina el Caso de Uso CU-04: Aplicar Cotización.
    /// </summary>
    public class CotizacionAppService
    {
        private readonly ICotizacionRepository _cotizacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CotizacionAppService(ICotizacionRepository cotizacionRepository, IUnitOfWork unitOfWork)
        {
            _cotizacionRepository = cotizacionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> AplicarCotizacion(string folio, string codigoCliente)
        {
            var cotizacion = await _cotizacionRepository.GetByFolioAsync(folio);
            
            if (!cotizacion.EstaVigente(DateTime.UtcNow))
            {
                // Emitir evento o manejar excepción de dominio
                return false; 
            }

            // Aquí se delegaría aplicar políticas de descuento usando las entidades
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}