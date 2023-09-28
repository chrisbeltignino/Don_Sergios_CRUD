using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;

namespace DonSergios.Infraestructure.Services
{
    public class AutoService : IAutoService
    {
        private readonly IAutoRepository _autoRepository;

        public AutoService(IAutoRepository autoRepository)
        {
            _autoRepository = autoRepository;
        }

        public void Create(AUTOS cCliente)
        {
            try
            {
                _autoRepository.Create(cCliente);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al agregar un auto: " + ex.Message);
            }
        }

        public List<AUTOS> Read()
        {
            try
            {
                return _autoRepository.Read();
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al leer los autos: " + ex.Message);
            }
        }

        public void Update(AUTOS cAuto)
        {
            try
            {
                _autoRepository.Update(cAuto);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al actualizar el auto: " + ex.Message);
            }
        }

        public void Delete(int cID)
        {
            try
            {
                _autoRepository.Delete(cID);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al borrar el auto: " + ex.Message);
            }
        }
    }
}
