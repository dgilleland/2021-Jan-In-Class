using System;

namespace WestWindSystem.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string JobTitle { get; set; }
        public int? ReportsTo { get; set; }
        public DateTime HireDate { get; set; }
        public string OfficePhone { get; set; }
        public string Extension { get; set; }
        public DateTime BirthDate { get; set; }
        public int AddressID { get; set; }
        public string HomePhone { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoMimeType { get; set; }
        public string Notes { get; set; }
        public bool? Active { get; set; }
        public DateTime? TerminationDate { get; set; }
        public bool OnLeave { get; set; }
        public string LeaveReason { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
