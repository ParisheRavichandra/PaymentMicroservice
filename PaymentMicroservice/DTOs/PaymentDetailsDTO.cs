using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PaymentandFeedback.API.DTOs
{
    public class PaymentDetailsDTO
    {  
        [Required]
        public int Id { get; set; }
        [Required]
        public  string Payment_type { get; set; }
        [Required]
        public  string Payment_date { get; set; }
        [Required]
        public  int Amount { get; set; }

    }
}
