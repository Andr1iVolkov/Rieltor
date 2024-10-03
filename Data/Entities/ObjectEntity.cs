using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rieltor.Data.Entities
{
    [Table("tblObjects")]
    public class ObjectEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TypeOfObject")]
        public int TypeOfObjectId { get; set; }
        public virtual TypesOfObjectsEntity TypeOfObject { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual CityEntity City { get; set; }

        [ForeignKey("District")]
        public int DistrictId { get; set; }
        public virtual DistrictEntity District { get; set; }
 
        [Required, StringLength(100)]
        public string Address { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        [Required]
        public int Area { get; set; }

        [Required]
        public int Floor { get; set; }

        [ForeignKey("Rieltor")]
        public int RieltorId { get; set; }
        public virtual RieltorEntity Rieltor { get; set; }

    }
}
