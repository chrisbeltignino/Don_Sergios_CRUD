using System.ComponentModel.DataAnnotations.Schema;

namespace DonSergios.Domain.Entities
{
    [Table("CLIENTES")]
    public partial class CLIENTES
    {
        public int ID { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string FACEBOOK { get; set; }
        public int? ID_AUTO { get; set; }
        public int? ID_SERVICIO { get; set; }

        public virtual AUTOS AUTOS { get; set; }

        public virtual SERVICIOS SERVICIOS { get; set; }
    }
}
