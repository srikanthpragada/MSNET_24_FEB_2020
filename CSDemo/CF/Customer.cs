using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.CF
{
    [Table("customers")]
    class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Column("mobile")]
        [MaxLength(10)]
        [Required]
        public string Mobile { get; set; }

    }
}
