using System;
using System.Collections.Generic;

namespace Accelerex.API.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public List<string> Data { get; set; }
    }
}
