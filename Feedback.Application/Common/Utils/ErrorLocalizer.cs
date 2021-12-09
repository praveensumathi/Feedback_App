using Feedback.Application.Resources;
using Microsoft.Extensions.Localization;

namespace Feedback.Application.Common.Utils
{
    public class ErrorLocalizer : IErrorLocalizer
    {
        private readonly IStringLocalizer<ErrorResource> localizer;

        public ErrorLocalizer(IStringLocalizer<ErrorResource> localizer)
        {
            this.localizer = localizer;
        }
        public string GetMessage(string key)
        {
            var value = localizer[key];
            if (value == key)
                return ErrorInProcessing;
            return value;
        }

        public string ErrorInProcessing => localizer["ErrorInProcessing"];
    }
}
