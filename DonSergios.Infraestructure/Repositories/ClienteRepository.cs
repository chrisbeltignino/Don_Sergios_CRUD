using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using System.Data.Entity;

namespace DonSergios.Infraestructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DBDON_SERGIOSEntities _dbContext;

        public ClienteRepository(DBDON_SERGIOSEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(CLIENTES cCliente)
        {
            _dbContext.CLIENTES.Add(cCliente);
            _dbContext.SaveChanges();
        }

        public List<CLIENTES> Read()
        {
            return _dbContext.CLIENTES.ToList();
        }

        public CLIENTES GetClienteByID(int clienteId)
        {
            try
            {
                // Utiliza LINQ para obtener el cliente por su ID desde el contexto de la base de datos
                return _dbContext.CLIENTES.FirstOrDefault(c => c.ID == clienteId);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la consulta
                throw new Exception("Error al obtener el cliente por ID: " + ex.Message, ex);
            }
        }

        public void Update(CLIENTES cCliente)
        {
            //_dbContext.Entry(cCliente).Reload();
            _dbContext.Entry(cCliente).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int cID)
        {
            var cliente = _dbContext.CLIENTES.Single(c => c.ID == cID);
            _dbContext.CLIENTES.Remove(cliente);
            _dbContext.SaveChanges();
        }

        public List<CLIENTES> BuscarTelefono(string cTelefono)
        {
            return _dbContext.CLIENTES
                                .Include(c => c.AUTOS)       // Cargar datos relacionados de AUTOS
                                .Include(c => c.SERVICIOS)   // Cargar datos relacionados de SERVICIOS
                                .Where(c => c.TELEFONO.Contains(cTelefono))
                                .ToList();
        }

        public List<CLIENTES> BuscarNombre(string cNombre)
        {
            try
            {
                return _dbContext.CLIENTES
                                 .Include(c => c.AUTOS)       // Cargar datos relacionados de AUTOS
                                 .Include(c => c.SERVICIOS)   // Cargar datos relacionados de SERVICIOS
                                 .Where(c => c.NOMBRES.Contains(cNombre))
                                 .ToList();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    throw new Exception("Error al buscar en la Base de Datos: " + ex.InnerException.Message, ex);
                }
                else
                {
                    throw new Exception("Error al buscar en la Base de Datos: " + ex.Message, ex);
                }
            }
        }

        public List<CLIENTES> GetClientesByModelo(string cModelo)
        {
            try
            {
                return _dbContext.CLIENTES
                        .Include(c => c.SERVICIOS)
                        .Include(c => c.AUTOS)
                        .Where(c => c.AUTOS != null && c.AUTOS.MODELOS != null && c.AUTOS.MODELOS.MODELO == cModelo)
                        .ToList();
                
            }
            catch (Exception ex)
            {

                throw new Exception("Error al buscar en la Base de Datos: " + ex.Message, ex);
            }
        }
    }
}
