using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rieltor.Data.Entities
{
    [Table("tblDistricts")]
    public class DistrictEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(500)]
        public string Name { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual CityEntity City { get; set; }
    }
}
