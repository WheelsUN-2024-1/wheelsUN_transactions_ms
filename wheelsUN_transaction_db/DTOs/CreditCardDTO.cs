﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace wheelsUN_transaction_db.DTOs
{
    public class CreditCardDTO
    {
        public int creditCardId { get; set; }
        public int userId { get; set; }
        public string number { get; set; }
        public string name { get; set; }
        public string securityCode { get; set; }
        public string expirationDate { get; set; }
    }
}
