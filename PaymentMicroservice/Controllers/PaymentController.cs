using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentandFeedback.API.DTOs;
using PaymentandFeedback.Domain.Entities;
using PaymentandFeedback.Domain.Interfaces;

namespace PaymentandFeedback.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IRepository<PaymentDetails> PaymentDetailsRepository;
        public PaymentController(IRepository<PaymentDetails> PaymentDetailsRepository)
        {
            this.PaymentDetailsRepository = PaymentDetailsRepository;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> AddFeedback(PaymentDetailsDTO dto)
        {
            var feed = new PaymentDetails(dto.Payment_type, dto.Payment_date, dto.Amount);
            PaymentDetailsRepository.Add(feed);
            await PaymentDetailsRepository.SaveAsync();
            return StatusCode(201);

        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<PaymentDetailsDTO>))]
        public IActionResult GetFeedback()
        {
            var Feedbacks = PaymentDetailsRepository.Get();
            var dtos = from feed in Feedbacks
                       select new PaymentDetailsDTO
                       {

                           Id = feed.Id,
                           Payment_date = feed.Payment_date,
                           Payment_type = feed.Payment_type,
                           Amount = feed.Amount
                       };
            return Ok(dtos);
        }
    }
}
