using DonSergios.Domain.Entities;

namespace DonSergios.Applications.Interfaces
{
    public interface IClienteService
    {
        void Create(CLIENTES cCliente);
        List<CLIENTES> Read();
        CLIENTES GetClienteByID(int ID);
        void Update(CLIENTES cCliente);
        void Delete(int cID);
        List<CLIENTES> BuscarTelefono(string cTelefono);
        List<CLIENTES> BuscarNombre(string cNombre);
        List<CLIENTES> GetClientesByModelo(string cModelo);
    }
}