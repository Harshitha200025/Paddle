using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;

namespace Paddle.Models
{
    public class Customer
    {
        [Key]
        public int cust_id { get; set; }
        public string name { get; set; }
        public string Email_id { get; set; }
        public int phone_no { get; set; }

    }
    
}