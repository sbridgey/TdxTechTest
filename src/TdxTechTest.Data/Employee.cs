using System;

namespace TdxTechTest.Data
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public EmployeeDetail EmployeeDetail { get; set; }
    }
}
