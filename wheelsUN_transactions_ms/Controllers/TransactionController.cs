﻿using Microsoft.AspNetCore.Mvc;
using wheelsUN_transactions_ms.Models;
using wheelsUN_transactions_ms.Services;

namespace wheelsUN_transactions_ms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController:ControllerBase
    {
        private readonly ISTransaction _transactions;

        public TransactionController(ISTransaction transactions)
        {
            _transactions = transactions;
        }

        [HttpPost]
        public async Task<object> PostCardPayment(RequestPayment payment)
        {
            try
            {
                var result = await _transactions.PostCardPayment(payment);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        
            
        }

        /* Por el momento este endpoint no se utiliza
        [HttpPost("api/")]
        public async Task<object> GetPaymentMethods(PaymentMethod paymentMethod)
        {
            try
            {
                var result = await _transactions.GetPaymentMethods(paymentMethod);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        */

    }
}