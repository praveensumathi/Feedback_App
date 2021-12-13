using System.Text.Json.Serialization;

namespace Feedback.Application.Common.Model
{
    public class CommonParameters : Pager
    {
        [JsonIgnore]
        public string LoggedInUserEmail { get; set; }
        public string SearchName { get; set; }
    }
}
