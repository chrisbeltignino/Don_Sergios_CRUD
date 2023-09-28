using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using System.Data.Entity;

namespace DonSergios.Infraestructure.Repositories
{
    public class ServicioRepository : IServicioRepository
    {
        private readonly DBDON_SERGIOSEntities _dbContext;

        public ServicioRepository(DBDON_SERGIOSEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(SERVICIOS sServicio)
        {
            _dbContext.SERVICIOS.Add(sServicio);
            _dbContext.SaveChanges();
        }

        public List<SERVICIOS> Read()
        {
            return _dbContext.SERVICIOS.ToList();
        }

        public void Update(SERVICIOS sServicio)
        {
            //_dbContext.Entry(sServicio).Reload();
            _dbContext.Entry(sServicio).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int sID)
        {
            var servicio = _dbContext.SERVICIOS.Single(s => s.ID_SERVICIO == sID);
            _dbContext.SERVICIOS.Remove(servicio);
            _dbContext.SaveChanges();
        }
    }
}
