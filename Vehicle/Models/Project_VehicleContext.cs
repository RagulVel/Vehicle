using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle.Models
{
    public partial class Project_VehicleContext : DbContext
    {
        public Project_VehicleContext()
        {
        }

        public Project_VehicleContext(DbContextOptions<Project_VehicleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminDetails> AdminDetails { get; set; }
        public virtual DbSet<LoanDetails> LoanDetails { get; set; }
        public virtual DbSet<LoanRequest> LoanRequest { get; set; }
        public virtual DbSet<PersonalDetails> PersonalDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-A0T17KR\\SQLEXPRESS;Database=Project_Vehicle;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminDetails>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK__Admin_de__B7946987715811FB");

                entity.ToTable("Admin_details");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoanDetails>(entity =>
            {
                entity.HasKey(e => e.LoanNumber)
                    .HasName("PK__Loan_Det__B3A704CD295DF807");

                entity.ToTable("Loan_Details");

                entity.Property(e => e.LoanNumber)
                    .HasColumnName("Loan_number")
                    .ValueGeneratedNever();

                entity.Property(e => e.Emi).HasColumnName("EMI");

                entity.Property(e => e.LoanAmount).HasColumnName("Loan_Amount");

                entity.Property(e => e.LoanDate)
                    .HasColumnName("Loan_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LoanTenure).HasColumnName("Loan_Tenure");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.RateOfInterest).HasColumnName("Rate_of_Interest");

                entity.Property(e => e.ReqId).HasColumnName("Req_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.LoanDetails)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__Loan_Detail__pid__1920BF5C");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.LoanDetails)
                    .HasForeignKey(d => d.ReqId)
                    .HasConstraintName("FK__Loan_Deta__Req_i__1A14E395");
            });

            modelBuilder.Entity<LoanRequest>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK__Loan_req__E3695B80B8DE2371");

                entity.ToTable("Loan_request");

                entity.Property(e => e.ReqId)
                    .HasColumnName("Req_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnnualSalary).HasColumnName("Annual_salary");

                entity.Property(e => e.ExShowroomPrice).HasColumnName("Ex_Showroom_Price");

                entity.Property(e => e.ExistingEmi)
                    .HasColumnName("Existing_EMI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingEmiAmt).HasColumnName("Existing_EMI_Amt");

                entity.Property(e => e.OnRoadPrice).HasColumnName("On_Road_price");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("Request_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfEmp)
                    .HasColumnName("Type_of_emp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfVehicle)
                    .HasColumnName("Type_of_vehicle")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleMake)
                    .HasColumnName("Vehicle_make")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleModel)
                    .HasColumnName("Vehicle_Model")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.LoanRequest)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK__Loan_reques__pid__164452B1");
            });

            modelBuilder.Entity<PersonalDetails>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Personal__DD37D91A036B3A99");

                entity.ToTable("Personal_details");

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Personal__B79469861E09175F")
                    .IsUnique();

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.AltMobileNo)
                    .HasColumnName("Alt_Mobile_No")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_of_Birth")
                    .HasColumnType("date");

                entity.Property(e => e.DoorNo)
                    .IsRequired()
                    .HasColumnName("Door_No")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("Email_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasColumnName("Mobile_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode).HasColumnName("Pin_code");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .IsRequired()
                    .HasColumnName("street_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
