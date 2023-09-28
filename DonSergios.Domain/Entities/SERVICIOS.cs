using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonSergios.Domain.Entities
{
    [Table("SERVICIOS")]
    public partial class SERVICIOS
    {
        [Key]
        public int ID_SERVICIO { get; set; }
        public string PROBLEMAS { get; set; }
        public string PRUEBAS { get; set; }
        public string REPUESTOS { get; set; }
        public double? PRECIO { get; set; }
        public string OBSERVACIONES { get; set; }
        public DateTime? FECHA_LLEGADA { get; set; }
        public DateTime? FECHA_SALIDA { get; set; }

        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
    }
}
