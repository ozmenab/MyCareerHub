using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCareerHub.Domain.Common;

namespace MyCareerHub.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string? LogoUrl { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}