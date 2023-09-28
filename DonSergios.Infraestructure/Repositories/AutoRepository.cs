using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using System.Data.Entity;

namespace DonSergios.Infraestructure.Repositories
{
    public class AutoRepository : IAutoRepository
    {
        private readonly DBDON_SERGIOSEntities _dbContext;

        public AutoRepository(DBDON_SERGIOSEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(AUTOS aAuto)
        {
            _dbContext.AUTOS.Add(aAuto);
            _dbContext.SaveChanges();
        }

        public List<AUTOS> Read()
        {
            return _dbContext.AUTOS.ToList();
        }

        public void Update(AUTOS aAuto)
        {
            //_dbContext.Entry(aAuto).Reload();
            _dbContext.Entry(aAuto).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int aID)
        {
            var auto = _dbContext.AUTOS.Single(a => a.ID_AUTO == aID);
            _dbContext.AUTOS.Remove(auto);
            _dbContext.SaveChanges();
        }
    }
}