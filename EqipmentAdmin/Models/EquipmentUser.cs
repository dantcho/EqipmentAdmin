using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class EquipmentUser
    {
        [Key]
        public int Id { get; set; }
        public string NameBG { get; set; }
        public string NameUS { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsForEvulation { get; set; }

    }
}