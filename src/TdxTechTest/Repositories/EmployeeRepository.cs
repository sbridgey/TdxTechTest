using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TdxTechTest.Data;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly ApiContext _apiContext;

        public EmployeeRepository(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        public Result_<List<EmployeeData>> GetAllEmployeeDetails()
        {
            var employees = _apiContext.Employees
                                       .Include(e => e.EmployeeDetail);

            var isSuccess = true && employees.Any();
            
            var result = new Result_<List<EmployeeData>>
            {
                IsSuccess = isSuccess,
                Data = employees.Select(e => new EmployeeData(e)).ToList()
            };

            return result;
        }

        public Result_<string> StoreEmployeeDetails(UploadedFile fileData)
        {
            foreach (var row in fileData.Rows)
            {
                _apiContext.Add<Employee>(new Employee { 
                    EmployeeId = row.EmployeeId, 
                    FirstName = row.FirstName, 
                    Surname = row.Surname,
                    EmployeeDetail = new EmployeeDetail{
                        DirectReportsCount = row.DirectReportsCount,
                        HourlyRate = row.HourlyRate,
                        EmployeeId = row.EmployeeId,
                        EmploymentDate = row.EmploymentDate
                    }
                });
            }

            _apiContext.SaveChanges();

            var result = new Result_<string>
            {
                IsSuccess = true
            };

            return result;
        }
    }
}
