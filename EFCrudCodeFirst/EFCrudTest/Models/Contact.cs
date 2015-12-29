using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace EFCrudTest.Models
{
    public class Contact
    {
        [Required]
        public Int32 ID { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }

    }

    public class DBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}