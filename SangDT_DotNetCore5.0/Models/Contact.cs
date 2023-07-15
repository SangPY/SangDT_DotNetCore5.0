using System.ComponentModel.DataAnnotations;

namespace SangDT_DotNetCore5._0.Models
{
    public class Contact
    {
        [Range(1,10)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Note { get; set; }

    }
}
