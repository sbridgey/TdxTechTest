using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TdxTechTest.FileUtilities;

namespace TdxTechTest.Controllers
{
    public class UploadController : ControllerBase
    {
        readonly FileProcessor _fileProcessor;

        public UploadController(FileProcessor fileProcessor)
        {
            _fileProcessor = fileProcessor;
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

            return Ok("File Upload Successful");
        }
    }
}
