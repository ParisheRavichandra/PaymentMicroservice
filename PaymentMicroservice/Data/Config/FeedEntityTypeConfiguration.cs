using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentandFeedback.Domain.Aggregates.FeedbackAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentandFeedback.Infrastructure.Data.Config
{
    public class PaymentsandFeedbacksEntityTypeConfiguration : IEntityTypeConfiguration<Feedbacks>
    {
        public void Configure(EntityTypeBuilder<Feedbacks> builder)
        {

            builder.Property(p => p.User_account_id).IsRequired(true).HasMaxLength(50);
            builder.Property(p => p.rating).IsRequired(true).HasMaxLength(50);
            builder.Property(p => p.Description).IsRequired(true).HasMaxLength(200);

        }


    }


}