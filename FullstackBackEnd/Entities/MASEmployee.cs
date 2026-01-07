using FullstackBackEnd.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullstackBackEnd.Entities
{
    [Table("MASEmployee")]
    public class MASEmployee : CommonEntity
    {
        [Key]
        public int PKMASEmployeeID { get; set; }
        [Required]
        [MaxLength(100)]
        public string EmployeeID { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        [MaxLength(1000)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int FKMASGenderID { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
