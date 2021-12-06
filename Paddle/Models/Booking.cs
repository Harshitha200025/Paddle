using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Paddle.Models
{
    public class Booking
    {
        [Key]
        public int Book_id { get; set; }
        [ForeignKey("customer_id")]
        public int cust_id { get; set; }
        public Customer customer_id { get; set; }
        [ForeignKey("court_id")]
        public int courtid { get; set; }
        public Court court_id { get; set; }
        public DateTime timing { get; set; }
        public int no_of_hrs { get; set; }
        public int payment { get; set; }
    }
    
}