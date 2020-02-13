using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserFileNote
    {
        public UserFileNote()
        {
            UserFileNoteDocument = new HashSet<UserFileNoteDocument>();
        }

        public Guid UserFileNoteId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DateFollowedUp { get; set; }
        public Guid? FollowedUpByUserId { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual Company Company { get; set; }
        public virtual User FollowedUpByUser { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserFileNoteDocument> UserFileNoteDocument { get; set; }
    }
}
