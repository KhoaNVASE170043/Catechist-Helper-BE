﻿using CatechistHelper.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatechistHelper.Domain.Entities
{
    [Table("application")]
    public class Application
    {
        [Key]
        public Guid Id { get; set; }

        [Column("status")]
        [EnumDataType(typeof(ApplicationStatus))]
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;

        [Column("candidate_id")]
        [ForeignKey(nameof(Candidate))]
        public Guid CandidateId { get; set; }
        public virtual Candidate Candidate { get; set; } = null!;

        [InverseProperty(nameof(Application))]
        public virtual ICollection<Interview> Interviews { get; set; } = new List<Interview>();

        [InverseProperty(nameof(Application))]
        public virtual ICollection<InterviewProcess> InterviewProcesses { get; set; } = new List<InterviewProcess>();

        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
        public virtual ICollection<Recruiter> Recruiters { get; set; } = new List<Recruiter>();
    }
}
