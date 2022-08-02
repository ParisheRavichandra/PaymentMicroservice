using PaymentandFeedback.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PaymentandFeedback.Domain.Aggregates;

namespace PaymentandFeedback.Domain.Entities
{
   public class PaymentDetails:EntityBase,IAggregateRoot
    {
        
        //public new virtual int id { get; set; }
        public virtual string Payment_type { get; set; }
        public virtual string Payment_date { get; set; }
        public virtual int Amount { get; set; }

        public PaymentDetails(string Payment_type, string Payment_date,int Amount)
        {
            //this.User_account_id = User_account_id;
            this.Payment_type = Payment_type;
            this.Payment_date = Payment_date;
            this.Amount = Amount;

        }
    }
}
