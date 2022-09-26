using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFATM.Models
{
    [Table("Carddetails")]
    public class Carddetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]

        public long? CardNumber { get; set; }

        public string CustomerName { get; set; }

        public int? Pin { get; set; }

    }
}
