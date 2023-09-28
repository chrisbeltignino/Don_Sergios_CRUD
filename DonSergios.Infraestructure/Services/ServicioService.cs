using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;

namespace DonSergios.Infraestructure.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IServicioRepository _servicioRepository; // Debes tener un repositorio para CLIENTES

        public ServicioService(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public void Create(SERVICIOS sServicio)
        {
            try
            {
                _servicioRepository.Create(sServicio);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al agregar un servicio: " + ex.Message);
            }
        }

        public List<SERVICIOS> Read()
        {
            try
            {
                return _servicioRepository.Read();
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al leer los servicios: " + ex.Message);
            }
        }

        public void Update(SERVICIOS sServicio)
        {
            try
            {
                _servicioRepository.Update(sServicio);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al actualizar el servicio: " + ex.Message);
            }
        }

        public void Delete(int cID)
        {
            try
            {
                _servicioRepository.Delete(cID);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al borrar el servicio: " + ex.Message);
            }
        }
    }
}
