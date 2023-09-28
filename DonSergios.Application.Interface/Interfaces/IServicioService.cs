using DonSergios.Domain.Entities;

namespace DonSergios.Applications.Interfaces
{
    public interface IServicioService
    {
        void Create(SERVICIOS sServicio);
        List<SERVICIOS> Read();
        void Update(SERVICIOS sServicio);
        void Delete(int sID);
    }
}