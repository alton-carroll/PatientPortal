using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PatientPortal.Models;

namespace PatientPortal.Models
{
    public class Referral
    {
        [Key]
        public int ReferralId { get; set; }
        public DateTime ReferralDate { get; set; }
        public string Doctor { get; set; }
        public string ReferralDoctor { get; set; }
        public string Procedure { get; set; }
        public string Location { get; set; }
        public string OpenedBy { get; set; }
        public DateTime OpenedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedOn { get; set; }
       
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
    }
}
