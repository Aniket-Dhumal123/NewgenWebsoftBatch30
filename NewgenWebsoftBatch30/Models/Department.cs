using System.ComponentModel.DataAnnotations;

namespace FinalNewProject.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required]
        public string DeptName { get; set; }

    }
}
