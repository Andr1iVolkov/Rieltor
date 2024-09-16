using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rieltor.Data.Entities
{
    [Table("tblTypesOfObjects")]
    public class TypesOfObjectsEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}
