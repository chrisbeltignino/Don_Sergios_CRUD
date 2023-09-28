using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonSergios.Domain.Entities
{
    [Table("AUTOS")]
    public partial class AUTOS
    {
        [Key]
        public int ID_AUTO { get; set; }
        public string PATENTE { get; set; }
        public string MOTOR { get; set; }
        public int? ID_MODELO { get; set; }
        public int? AÑO { get; set; }


        public virtual ICollection<CLIENTES> CLIENTES { get; set; }
        public virtual MODELOS MODELOS { get; set; }
    }
}