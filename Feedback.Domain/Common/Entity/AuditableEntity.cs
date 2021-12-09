using System;

namespace Feedback.Domain.Common.Entity
{
    public abstract class AuditableEntity
    {
        public long CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
