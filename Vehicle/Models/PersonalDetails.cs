using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle.Models
{
    public partial class PersonalDetails
    {
        public PersonalDetails()
        {
            LoanDetails = new HashSet<LoanDetails>();
            LoanRequest = new HashSet<LoanRequest>();
        }

        public int Pid { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string AltMobileNo { get; set; }
        public string Password { get; set; }
        public string DoorNo { get; set; }
        public string StreetName { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }

        public virtual ICollection<LoanDetails> LoanDetails { get; set; }
        public virtual ICollection<LoanRequest> LoanRequest { get; set; }
    }
}
