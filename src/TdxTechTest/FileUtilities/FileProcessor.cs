using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class FileProcessor : IFileParser, IFileValidator
    {
        private readonly IEnumerable<IValidator> _validators;

        public FileProcessor(IEnumerable<IValidator> validators)
        {
            _validators = validators;
        }

        public Result_<UploadedFile> ParseFile(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Result_<List<string>> ValidateFile(UploadedFile file)
        {
            var result = new Result_<List<string>> { IsSuccess = true, Data = new List<string> };

            foreach (var row in file.Row)
            {
                foreach(var validator in _validators)
                {
                    validator.ValidateColumn(result, row);
                }
            }

            return result;
        }
    }
}
