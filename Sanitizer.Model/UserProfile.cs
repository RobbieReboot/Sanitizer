using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            UserProfileFile = new HashSet<UserProfileFile>();
        }

        public Guid UserProfileId { get; set; }
        public Guid CompanyId { get; set; }
        public string EmployeeReference { get; set; }
        public string OtdrPin { get; set; }
        public Guid BaseLocationId { get; set; }
        public decimal? TravellingTime { get; set; }
        public Guid? AssessorId { get; set; }
        public Guid? LineManagerId { get; set; }
        public string LicenceNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public string BirthplacePostcode { get; set; }
        public string BirthplaceTown { get; set; }
        public string Nationality { get; set; }
        public string NativeLanguage { get; set; }
        public Guid PermanentAddressId { get; set; }
        public bool CompetencyCyclesNotApplicable { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool HeadOfDriving { get; set; }
        public bool HeadOfOperations { get; set; }
        public string Timezone { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual User Assessor { get; set; }
        public virtual Location BaseLocation { get; set; }
        public virtual Company Company { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual User LineManager { get; set; }
        public virtual Address PermanentAddress { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<UserProfileFile> UserProfileFile { get; set; }
    }
}
