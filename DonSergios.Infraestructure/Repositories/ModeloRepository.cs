using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;

namespace DonSergios.Infraestructure.Repositories
{
    public class ModeloRepository : IModeloRepository
    {
        private readonly DBDON_SERGIOSEntities _dbContext;

        public ModeloRepository(DBDON_SERGIOSEntities dbContext)
        {
            _dbContext = dbContext;
        }
        public List<MODELOS> Read()
        {
            return _dbContext.MODELOS.ToList();
        }
    }
}
