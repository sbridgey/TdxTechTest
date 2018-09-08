using System;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;

namespace TdxTechTest.FileUtilities
{
    public class FileParser : IFileParser
    {
        public FileParser()
        {
        }

        public FileValidationResult ValidateFile(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
