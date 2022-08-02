using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PaymentandFeedback.Domain.Aggregates.FeedbackAggregate;
using PaymentandFeedback.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentandFeedback.Infrastructure.Data.Contexts
{
    public class PaymentandFeedbackManagementContexts : DbContext
    {
        public PaymentandFeedbackManagementContexts(DbContextOptions options) : base(options)
        {

        }
      
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PaymentandFeedbackManagementContexts).Assembly);
        }


    }
}