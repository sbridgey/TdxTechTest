using System;
using System.Collections.Generic;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class BaseValidator
    {
        protected void AddError(Result_<List<string>> result, string errorMessage)
        {
            result.IsSuccess = false;
            result.Data.Add(errorMessage);
        }
    }
}
