using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonSergios.Infraestructure.Services
{
    public class RepuestoService : IRepuestoService
    {
        private readonly IRepuestoRepository _repuestoRepository; // Debes tener un repositorio para CLIENTES

        public RepuestoService(IRepuestoRepository repuestoRepository)
        {
            _repuestoRepository = repuestoRepository;
        }

        public void Create(REPUESTOS rRepuesto)
        {
            try
            {
                _repuestoRepository.Create(rRepuesto);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al agregar un repuesto " + ex.Message);
            }
        }

        public List<REPUESTOS> Read()
        {
            try
            {
                return _repuestoRepository.Read();
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al leer los repuestos " + ex.Message);
            }
        }

        public REPUESTOS GetRepuestoByID(int repuestoId)
        {
            // Llama al método del repositorio para obtener un cliente por su ID
            return _repuestoRepository.GetRepuestoByID(repuestoId);
        }

        public void Update(REPUESTOS rRepuesto)
        {
            try
            {
                _repuestoRepository.Update(rRepuesto);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al actualizar el repuesto " + ex.Message);
            }
        }

        public void Delete(int rID)
        {
            try
            {
                _repuestoRepository.Delete(rID);
            }
            catch (Exception ex)
            {
                throw new Exceptions("Error al borrar el repuesto " + ex.Message);
            }
        }
    }
}
