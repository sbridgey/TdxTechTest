using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TdxTechTest.FileUtilities;
using TdxTechTest.Interfaces;

namespace TdxTechTest.Controllers
{
    public class UploadController : ControllerBase
    {
        readonly FileProcessor _fileProcessor;
        readonly IEmployeeRepository _employeeRepository;

        public UploadController(FileProcessor fileProcessor, IEmployeeRepository employeeRepository)
        {
            _fileProcessor = fileProcessor;
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            var a = file.FileName;

            var parseResult = _fileProcessor.ParseFile(file);

            if (!parseResult.IsSuccess)
                return BadRequest("Error Parsing File");

            var parsedFileResult = _fileProcessor.ValidateFile(parseResult.Data);

            if (!parsedFileResult.IsSuccess)
                return BadRequest(parsedFileResult.Data);

            _employeeRepository.StoreEmployeeDetails(parseResult.Data);

            return Ok("File Upload Successful");
        }
    }
}
