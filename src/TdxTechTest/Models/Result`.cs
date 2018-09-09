using System;
namespace TdxTechTest.Models
{
    public class Result_<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
    }
}
