using System;
using System.Collections.Generic;

namespace TdxTechTest.Models
{
    public class FileValidationResult
    {
        public bool IsFileValid { get; set; }
        public List<string> Errors { get; set; }
    }
}