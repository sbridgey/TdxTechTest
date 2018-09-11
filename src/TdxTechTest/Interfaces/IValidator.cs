using System;
using System.Collections.Generic;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IValidator
    {
        void ValidateColumn(Result_<List<string>> result, FileRow row);
    }
}
