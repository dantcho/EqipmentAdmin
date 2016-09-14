using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public  virtual ApplicationUser User { get; set; }
        public string Message { get; set; }
        public virtual Ticket TicketId { get; set; }

    }
}