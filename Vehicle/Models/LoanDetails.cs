using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle.Models
{
    public partial class LoanDetails
    {
        public int LoanNumber { get; set; }
        public int? Pid { get; set; }
        public double LoanAmount { get; set; }
        public int LoanTenure { get; set; }
        public double RateOfInterest { get; set; }
        public DateTime? LoanDate { get; set; }
        public string Status { get; set; }
        public int? ReqId { get; set; }
        public double Emi { get; set; }

        public virtual PersonalDetails P { get; set; }
        public virtual LoanRequest Req { get; set; }
    }
}
