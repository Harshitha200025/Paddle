using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Paddle.Models
{
    public class Location
    {
        [Key]
        public int locid { get; set; }
        public string locname { get; set; }
        public int no_of_courts { get; set; }
    }
    public class Court
    {
        [Key]
        public int c_id { get; set; }
        [ForeignKey("location_id")]
        public int loc_id { get; set; }
        public Location location_id { get; set; }
        public float price { get; set; }
        public DateTime avail_time { get; set; }
    }
    public class PaddleContext: DbContext
    {
        public DbSet<Location> location { get; set; }
        public DbSet<Court> court { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Customer> customers { get; set; }

    }
}