using Feedback.Application.Common.Contracts.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IDbConnection connection = null;
        IDbTransaction transaction = null;
        private readonly IHttpContextAccessor httpContextAccessor;

        #region PrivateRepositories
        private IEventRepository eventRepository;
        private IQuestionRepository questionRepository;
        private IAnswerRepository answerRepository;
        #endregion

        public UnitOfWork(IDbConnection dbConnection, IHttpContextAccessor httpContextAccessor)
        {
            connection = dbConnection;
            this.httpContextAccessor = httpContextAccessor;
        }

        public IEventRepository EventRepository
        {
            get
            {
                if (eventRepository == null)
                {
                    eventRepository = (IEventRepository)httpContextAccessor.HttpContext.RequestServices.GetService(typeof(IEventRepository)); ;
                }
                return eventRepository;
            }
        }

        public IQuestionRepository QuestionRepository => throw new NotImplementedException();

        public IAnswerRepository AnswerRepository => throw new NotImplementedException();

        public IQuestionTemplateRepository QuestionTemplateRepository => throw new NotImplementedException();

        public IDbConnection Connection
        {
            get { return connection; }
        }

        public IDbTransaction Transaction
        {
            get { return transaction; }
        }

        public IDbTransaction Begin()
        {
            transaction = connection.BeginTransaction();
            return transaction;
        }

        public void Commit()
        {
            transaction.Commit();
            Dispose();
        }

        public void Dispose()
        {
            if (transaction != null)
                transaction.Dispose();
            transaction = null;
        }

        public void Rollback()
        {
            transaction.Rollback();
            Dispose();
        }
    }
}
