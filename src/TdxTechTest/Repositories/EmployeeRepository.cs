using System.Collections.Generic;
using System.Linq;
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
            var employees = _apiContext.Employees;
            var isSuccess = true && employees.Any();
            
            var result = new Result_<List<EmployeeData>>
            {
                IsSuccess = isSuccess,
                Data = employees.Select(e => new EmployeeData().FromEmployee(e)).ToList()
            };

            return result;
        }

        public Result_<string> StoreEmployeeDetails(UploadedFile fileData)
        {
            foreach (var row in fileData.Row)
            {
                _apiContext.Add(new Employee { 
                    EmployeeId = row.EmployeeId, 
                    FirstName = row.FirstName, 
                    Surname = row.Surname 
                });
            }

            var result = new Result_<string>
            {
                IsSuccess = true
            };

            return result;
        }
    }
}
