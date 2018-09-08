using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TdxTechTest.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TdxTechTest.Controllers
{
    public class UploadController : Controller
    {
        private readonly IFileParser _fileParser;

        public UploadController(IFileParser fileParser)
        {
            _fileParser = fileParser;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            var a = file.FileName;

            var validationResult = _fileParser.ValidateFile(file);

            if (!validationResult.IsFileValid)
                return BadRequest(validationResult.Errors);

            var parsedFile = _fileParser.ParseFile();

            return Ok("File Upload Successful");
        }
    }
}
