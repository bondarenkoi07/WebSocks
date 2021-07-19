using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebSocks.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string message { get; set; }
        public string sender { get; set; }
    }

    public class MessageDBContext: DbContext
    {
        public DbSet<Message> messages { get; set; }
    }
}