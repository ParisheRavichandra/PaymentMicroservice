using PaymentandFeedback.Domain.Aggregates;
using PaymentandFeedback.Domain.Entities;
using PaymentandFeedback.Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentandFeedback.Infrastructure.Data.Contexts;

namespace PaymentandFeedback.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase, IAggregateRoot
    {
        private readonly PaymentandFeedbackManagementContexts context;
        public Repository(PaymentandFeedbackManagementContexts context)
        {
            this.context = context;
        }

        public T Add(T item)
        {
            return context.Add(item).Entity;

        }

        public IReadOnlyCollection<T> Get()
        {

            var Data = context.Set<T>().ToList();
            return Data.AsReadOnly();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);

        }

      

        public T Remove(T item)
        {
            return context.Remove(item).Entity;

        }



        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();

        }

        


    }
}