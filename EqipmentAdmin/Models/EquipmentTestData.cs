using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EqipmentAdmin.Models
{
    public class EquipmentTestData

    {
        [Key]
        public int Id { get; set; }
     //   public EquipmentStatus EstId { get; set; }
        public bool HRay_1_1 { get; set; }
        public bool HRay_1_2 { get; set; }
        public bool HRay_1_3 { get; set; }
        public bool HRay_1_4 { get; set; }
        public bool HRay_2_1 { get; set; }
        public bool HRay_2_2 { get; set; }
        public bool HRay_2_3 { get; set; }
        public bool HRay_2_4 { get; set; }
        public bool WMTD_2_2 { get; set; }
        public bool WMTD_2_3 { get; set; }
        public bool WMTD_2_4 { get; set; }
        public bool IONSCAN_VERIF_TEST { get; set; }
    }
}