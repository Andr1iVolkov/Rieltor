using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rieltor.Data.Entities
{
    [Table("tblCities")]
    public class CityEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(500)]
        public string Name { get; set; }
    }
}
