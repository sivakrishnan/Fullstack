using FullstackBackEnd.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullstackBackEnd.Entities
{
    [Table("MAPEmployeeCourse")]
    public class MAPEmployeeCourse : CommonEntity
    {
        [Key]
        public int PKMAPEmployeeCourseID { get; set; }
        [Required]
        public int FKMASEmployeeID { get; set; }
        [Required]
        public int FKMASCourseID { get; set; }
    }
}
