using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagemet.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }

        public int Marks { get; set;}
    }
}
