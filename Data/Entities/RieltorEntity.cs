using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rieltor.Data.Entities
{
    [Table("tblRieltors")]
    public class RieltorEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string LastName { get; set; }
        [Required, StringLength(5000)]
        public string Image { get; set; }
        [Required, StringLength(10000)]
        public string AboutYourself { get; set; }
        [Required, StringLength(100)]
        public string PhoneNumber { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(100)]
        public string Instagram { get; set; }
        [Required, StringLength(100)]
        public string Telegram { get; set; }
 

    }
}
