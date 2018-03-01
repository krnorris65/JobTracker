using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        public string Notes { get; set; }

        public bool Active { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
    }
}
