using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserRecruitmentDetail
    {
        public UserRecruitmentDetail()
        {
            UserRecruitmentDetailFile = new HashSet<UserRecruitmentDetailFile>();
        }

        public Guid UserRecruitmentDetailId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ResultsRequired { get; set; }
        public string Notes { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? RecruitmentResult { get; set; }
        public Guid? ResultAddedByUserId { get; set; }

        public virtual Company Company { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual User ResultAddedByUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserRecruitmentDetailFile> UserRecruitmentDetailFile { get; set; }
    }
}
