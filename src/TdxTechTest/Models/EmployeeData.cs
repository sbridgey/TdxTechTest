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
        public double HourlyRate { get; set; }
        public int DirectReportsCount { get; set; }

        public EmployeeData(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            FirstName = employee.FirstName;
            Surname = employee.Surname;
            if (employee.EmployeeDetail != null)
            {
                EmploymentDate = employee.EmployeeDetail.EmploymentDate;
                HourlyRate = employee.EmployeeDetail.HourlyRate;
                DirectReportsCount = employee.EmployeeDetail.DirectReportsCount;
            }
        }
    }
}
