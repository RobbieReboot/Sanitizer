﻿using System;

namespace Sanitizer.Model
{
    public partial class InfrastructureAuthorisedToOperateSigningHistory
    {
        public Guid InfrastructureAuthorisedToOperateSigningHistoryId { get; set; }
        public Guid InfrastructureAuthorisedToOperateId { get; set; }
        public DateTime SignedDateTime { get; set; }
        public DateTime? ExpiryDateTime { get; set; }
        public DateTime? RenewedDateTime { get; set; }
        public Guid? SignedByUserId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedByUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual InfrastructureAuthorisedToOperate InfrastructureAuthorisedToOperate { get; set; }
        public virtual User ModifiedByUser { get; set; }
        public virtual User SignedByUser { get; set; }
    }
}
