using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Repositories;

namespace DonSergios.Infraestructure.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository; // Debes tener un repositorio para CLIENTES

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Create(CLIENTES cCliente)
        {
            try
            {
                _clienteRepository.Create(cCliente);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al agregar un cliente " + ex.Message);
            }
        }

        public List<CLIENTES> Read()
        {
            try
            {
                return _clienteRepository.Read();
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al leer los clientes " + ex.Message);
            }
        }

        public CLIENTES GetClienteByID(int clienteId)
        {
            // Llama al método del repositorio para obtener un cliente por su ID
            return _clienteRepository.GetClienteByID(clienteId);
        }

        public void Update(CLIENTES cCliente)
        {
            try
            {
                _clienteRepository.Update(cCliente);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al actualizar el cliente " + ex.Message);
            }
        }

        public void Delete(int cID)
        {
            try
            {
                _clienteRepository.Delete(cID);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al borrar el cliente " + ex.Message);
            }
        }

        public List<CLIENTES> BuscarTelefono(string cTelefono)
        {
            try
            {
                return _clienteRepository.BuscarTelefono(cTelefono);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al encontrar el cliente " + ex.Message);
            }
        }

        public List<CLIENTES> BuscarNombre(string cNombre)
        {
            try
            {
                return _clienteRepository.BuscarNombre(cNombre);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al encontrar el cliente " + ex.Message);
            }
        }

        public List<CLIENTES> GetClientesByModelo(string cModelo)
        {
            try
            {
                return _clienteRepository.GetClientesByModelo(cModelo);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al encontrar los clientes " + ex.Message);
            }
        }
    }
}
