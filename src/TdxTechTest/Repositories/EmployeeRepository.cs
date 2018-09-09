using System;
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

        public Result_<string> GetAllEmployeeDetails()
        {
            throw new NotImplementedException();
        }

        public Result_<string> StoreEmployeeDetails(UploadedFile fileData)
        {
            throw new NotImplementedException();
        }
    }
}
