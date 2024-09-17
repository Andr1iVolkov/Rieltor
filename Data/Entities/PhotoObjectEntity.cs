using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace Rieltor.Data.Entities
{
    [Table("tblPhotosObjects")]
    public class PhotoObjectEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual ObjectEntity Object { get; set; }

        [Required, StringLength(5000)]
        public string Image { get; set; }


    }
}
