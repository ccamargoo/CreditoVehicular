using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace nombremicroservicio.Entities.Models
{
    [Table("tblMarcas")]
    public class MarcaModel
    {
        public int id { get; set; }
        public string marca { get; set; } 
    }
}
