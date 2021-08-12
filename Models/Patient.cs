using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientPortal.Models
    {
    public class Patient
        {
        [Display(Name = "Patient ID")]
        [Key]
        public int PatientId { get; set; }
        public string Title { get; set; }
        [Display(Name = "First Name")]
        //[Required]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        //[Required]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        //[Required]
        public string LastName { get; set; }
        public string Suffix { get; set; }

        [Display(Name = "Last Name")]
        public string FullName
            {
            get { return FirstName + " " + MiddleName + " " + LastName + " " + Suffix; }
            }

        [Display(Name = "Date of Birth")]
        //[Required]
        public DateTime Dob { get; set; }
        [Display(Name = "Social Security Number")]
        //[Required]
        public string Ssn { get; set; }
        [Display(Name = "Active Patient?")]
        public bool Active { get; set; }

        //[Required]
        public string Street { get; set; }
        //[Required]
        public string Apartment { get; set; }
        public string City { get; set; }
        //[Required]
        public string State { get; set; }
        //[Required]
        public string Zip { get; set; }


        //Insurance Data
        [Display(Name = "Primary Insurance Provider")]
        //[Required]
        public string PrimaryInsurance { get; set; }
        [Display(Name = "Primary Insurance ID Number")]
        //[Required]
        public string PrimaryInsuranceID { get; set; }
        [Display(Name = "Primary Insurance Holder")]
        //[Required]
        public string PrimaryInsuranceHolder { get; set; }

        [Display(Name = "Secondary Insurance Provider")]
        public string SecondaryInsurance { get; set; }
        [Display(Name = "Secondary Insurance ID Number")]
        public string SecondaryInsuranceID { get; set; }
        [Display(Name = "Secondary Insurance Holder")]
        public string SecondaryInsuranceHolder { get; set; }

        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
        }
    }
