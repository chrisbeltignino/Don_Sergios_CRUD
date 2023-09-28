using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;

namespace DonSergios.Infraestructure.Services
{
    public class ModeloService : IModeloService
    {
        private readonly IModeloRepository _modeloRepository; // Debes tener un repositorio para CLIENTES

        public ModeloService(IModeloRepository modeloRepository)
        {
            _modeloRepository = modeloRepository;
        }
        public List<MODELOS> Read()
        {
            try
            {
                return _modeloRepository.Read();
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al leer los modelos: " + ex.Message);
            }
        }
    }
}
