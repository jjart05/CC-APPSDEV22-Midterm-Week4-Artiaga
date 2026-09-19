using System.ComponentModel.DataAnnotations;

namespace StudentRosterApi.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Course { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(1, 4, ErrorMessage = "YearLevel must be between 1 and 4.")]
        public int YearLevel { get; set; }
    }
}
