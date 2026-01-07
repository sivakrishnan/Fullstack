using FullstackBackEnd.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullstackBackEnd.Entities
{
    [Table("MASGender")]
    public class MASGender : CommonEntity
    {
        [Key]
        public int PKMASGenderID { get; set; }
        [Required]
        [MaxLength(100)]
        public string GenderName { get; set; } = string.Empty;
    }
}
