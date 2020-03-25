using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CsharpDemo.EF
{
    [Table("categories")]
    class Category
    {
        [Column("catcode")]
        [Key]
        public string Code { get; set; }

        [Column("catdesc")]
        public string Description { get; set; }

    }
}
