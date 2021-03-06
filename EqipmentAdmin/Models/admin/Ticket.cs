﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool Resolved { get; set; }
        public virtual ApplicationUser IssueUser { get; set; }
        public virtual Equipment IssueEquip { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}