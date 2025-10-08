using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCareerHub.Domain.Common;

namespace MyCareerHub.Domain.Entities
{
    public class JobApplication : BaseEntity
    {
       public string CoverLetter { get; set; } = null!;

        public int JobId { get; set; }
        public Job Job { get; set; } = null!;

        public string ApplicantId { get; set; } = null!;
        // Navigation property’yi interface üzerinden kur
        public IApplicationUser Applicant { get; set; } = null!;
    }
}