using DonSergios.Applications.Interfaces;
using DonSergios.Domain.Entities;
using DonSergios.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonSergios.Infraestructure.Repositories
{
    public class RepuestoRepository : IRepuestoRepository
    {
        private readonly DBDON_SERGIOSEntities _dbContext;

        public RepuestoRepository(DBDON_SERGIOSEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(REPUESTOS rRepuesto)
        {
            _dbContext.REPUESTOS.Add(rRepuesto);
            _dbContext.SaveChanges();
        }

        public List<REPUESTOS> Read()
        {
            return _dbContext.REPUESTOS.ToList();
        }

        public REPUESTOS GetRepuestoByID(int repuestoId)
        {
            try
            {
                // Utiliza LINQ para obtener el cliente por su ID desde el contexto de la base de datos
                return _dbContext.REPUESTOS.FirstOrDefault(r => r.ID_REPUESTO == repuestoId);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la consulta
                throw new Exception("Error al obtener el repuesto por ID: " + ex.Message, ex);
            }
        }

        public void Update(REPUESTOS rRepuesto)
        {
            //_dbContext.Entry(cCliente).Reload();
            _dbContext.Entry(rRepuesto).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int rID)
        {
            var repuesto = _dbContext.REPUESTOS.Single(r => r.ID_REPUESTO == rID);
            _dbContext.REPUESTOS.Remove(repuesto);
            _dbContext.SaveChanges();
        }
    }
}
