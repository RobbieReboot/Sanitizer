﻿using System;
using System.Collections.Generic;

namespace Sanitizer.Model
{
    public partial class EmployeeSafetyCriticalStatus
    {
        public EmployeeSafetyCriticalStatus()
        {
            UserSafetyCriticalStatus = new HashSet<UserSafetyCriticalStatus>();
        }

        public Guid EmployeeSafetyCriticalStatusId { get; set; }
        public string Reference { get; set; }
        public string Colour { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<UserSafetyCriticalStatus> UserSafetyCriticalStatus { get; set; }
    }
}
