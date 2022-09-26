using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFATM.Models
{
    [Table("TransDetails")]
    public class TransDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public Decimal AccBal { get; set; }

        public DateTime? TransDate { get; set; }

        public long? CardNumber { get; set; }
    }
}
