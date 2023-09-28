using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonSergios.Domain.Entities
{
    [Table("MODELOS")]
    public partial class MODELOS
    {
        [Key]
        public int ID_MODELO { get; set; }
        public string MODELO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTOS> AUTOS { get; set; }
    }
}
