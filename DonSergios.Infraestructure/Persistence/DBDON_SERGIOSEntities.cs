using DonSergios.Domain.Entities;
using System.Data.Entity;

namespace DonSergios.Infraestructure.Persistence
{
    public class DBDON_SERGIOSEntities : DbContext
    {
        public DBDON_SERGIOSEntities() : base("Data Source=.; Initial Catalog=DON_SERGIOS; Integrated Security=True")
        {
            // Configuración adicional si es necesaria
            // this.Configuration.ProxyCreationEnabled = false;
            // this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<AUTOS> AUTOS { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<MODELOS> MODELOS { get; set; }
        public virtual DbSet<SERVICIOS> SERVICIOS { get; set; }
        public virtual DbSet<REPUESTOS> REPUESTOS { get; set; }

        // Otros métodos y configuraciones del contexto si es necesario
    }
}
