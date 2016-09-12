using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class UserActivity
    {
        [Key]
        public int Id { get; set; }
        public virtual EquipmentUser UserId { get; set; }
        public DateTime Date { get; set; }
        public virtual Equipment Machine { get; set; }
        public virtual SecurityChekSiteLocation Site { get; set; }
        public int BagCount { get; set; }
        public int TipMiss { get; set; }
        public int TipHit { get; set; }
        public int FalseHit { get; set; }
    }
}