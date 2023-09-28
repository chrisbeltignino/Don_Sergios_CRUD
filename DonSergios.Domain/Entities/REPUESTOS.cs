﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DonSergios.Domain.Entities
{
    [Table("REPUESTOS")]
    public partial class REPUESTOS
    {
        [Key]
        public int ID_REPUESTO { get; set; }
        public string NOMBRE { get; set; }
        public string MARCA { get; set; }
        public int? PRECIO { get; set; }
        public string DESCRIPCION { get; set; }
    }
}
