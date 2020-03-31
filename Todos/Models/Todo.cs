using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todos.Models
{
    [Table("Todos")]
    public class Todo
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("category")]
        public string Category { get; set; }


        [Column("Todo")]
        [Required]
        public string Text { get; set; }


        [Column("AddedOn")]
        public DateTime AddedOn { get; set; }



    }
}
