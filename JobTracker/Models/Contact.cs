using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public string Notes { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public ICollection<Job> Jobs { get; set; }

    }
}
