using PaymentandFeedback.Domain.Aggregates;
using PaymentandFeedback.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentandFeedback.Domain.Interfaces
{
    public interface IRepository<T> where T : EntityBase,IAggregateRoot
    {
        T Add(T item);
        T Remove(T item);
        IReadOnlyCollection<T> Get();
        Task<int> SaveAsync();
        T GetById(int id);

    }
}