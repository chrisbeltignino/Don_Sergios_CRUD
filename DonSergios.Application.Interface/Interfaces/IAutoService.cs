using DonSergios.Domain.Entities;

namespace DonSergios.Applications.Interfaces
{
    public interface IAutoService
    {
        void Create(AUTOS aAuto);
        List<AUTOS> Read();
        void Update(AUTOS aAuto);
        void Delete(int aID);
    }
}
