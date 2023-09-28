using DonSergios.Domain.Entities;

namespace DonSergios.Applications.Interfaces
{
    public interface IModeloRepository
    {
        public List<MODELOS> Read();
    }
}