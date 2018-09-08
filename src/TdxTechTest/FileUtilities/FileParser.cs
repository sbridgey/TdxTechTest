using System;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class FileParser : IFileParser
    {
        public UploadedFile ParseFile()
        {
            throw new NotImplementedException();
        }

        public FileValidationResult ValidateFile(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
