using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual ApplicationUser UserId { get; set; }
        public string MessageToLog { get; set; }
    }
}