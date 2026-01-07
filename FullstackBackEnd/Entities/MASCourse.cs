using FullstackBackEnd.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullstackBackEnd.Entities
{
    [Table("MASCourse")]
    public class MASCourse : CommonEntity
    {
        [Key]
        public int PKMASCourseID { get; set; }
        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; } = string.Empty;
    }
}
