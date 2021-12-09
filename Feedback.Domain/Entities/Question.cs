using Feedback.Domain.Common.Entity;

namespace Feedback.Domain.Entities
{
    public class Question : BaseEntity
    {
        public bool IsMandatory { get; set; }
    }
}
