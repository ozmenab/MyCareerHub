using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCareerHub.Domain.Common;

namespace MyCareerHub.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public decimal? Salary { get; set; }
        public bool IsActive { get; set; } = true;

        public int CompanyId { get; set; }
        public Company Company { get; set; } = null!;

        public ICollection<JobApplication> Applications { get; set; } = new List<JobApplication>();
    }
}