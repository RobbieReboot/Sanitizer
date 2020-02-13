using System;

namespace Sanitizer.Model
{
    public partial class UserEndedCompetencyCycle
    {
        public Guid UserEndedCompetencyCycleId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public Guid CompetencyCycleId { get; set; }
        public string Note { get; set; }
        public Guid EndedByUserId { get; set; }
        public DateTime DateEnded { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompetencyCycle CompetencyCycle { get; set; }
        public virtual User EndedByUser { get; set; }
        public virtual User User { get; set; }
    }
}
