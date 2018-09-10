using System;
using TdxTechTest.Data;

namespace TdxTechTest.Models
{
    public class EmployeeData
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double PayGrade { get; set; }
        public int DirectReportsCount { get; set; }

        public EmployeeData FromEmployee(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            FirstName = employee.FirstName;
            Surname = employee.Surname;
            EmploymentDate = employee.EmployeeDetail.EmploymentDate;
            PayGrade = employee.EmployeeDetail.PayGrade;
            DirectReportsCount = employee.EmployeeDetail.DirectReportsCount;
            return this;
        }
    }
}
