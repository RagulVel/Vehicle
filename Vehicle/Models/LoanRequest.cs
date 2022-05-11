using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle.Models
{
    public partial class LoanRequest
    {
        public LoanRequest()
        {
            LoanDetails = new HashSet<LoanDetails>();
        }

        public int ReqId { get; set; }
        public int? Pid { get; set; }
        public string TypeOfEmp { get; set; }
        public double? AnnualSalary { get; set; }
        public string ExistingEmi { get; set; }
        public double? ExistingEmiAmt { get; set; }
        public string TypeOfVehicle { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public double? ExShowroomPrice { get; set; }
        public double? OnRoadPrice { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Status { get; set; }

        public virtual PersonalDetails P { get; set; }
        public virtual ICollection<LoanDetails> LoanDetails { get; set; }
    }
}
