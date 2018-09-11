using System;
using System.Collections.Generic;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class DoubleValidator : BaseValidator, IValidator
    {
        readonly double _minimumHourlyRate = 7.20;

        public void ValidateColumn(Result_<List<string>> result, FileRow row)
        {
            if (row.HourlyRate < _minimumHourlyRate)
            {
                AddError(result, "Hourly rate too low");
            }
        }
    }
}
