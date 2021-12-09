namespace Feedback.Application.Common.Utils
{
    public interface IErrorLocalizer
    {
        string GetMessage(string key);
        string ErrorInProcessing { get; }
    }
}
