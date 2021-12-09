using System;
using System.Data;

namespace Feedback.Application.Common.Contracts.Repositories
{
    /// <summary>
    /// Unit of work is responsible for all the repository transactions
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository EventRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IAnswerRepository AnswerRepository { get; }
        IQuestionTemplateRepository QuestionTemplateRepository { get; }

        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }
        IDbTransaction Begin();
        void Commit();
        void Rollback();
    }
}
