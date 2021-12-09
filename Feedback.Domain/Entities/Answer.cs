using Feedback.Domain.Common.Entity;

namespace Feedback.Domain.Entities
{
    public class Answer : BaseEntity 
    {
        public string AnsweredBy { get; set; }
    }
}
