using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) // Data and message
        {

        }
        public ErrorDataResult(T data) : base(data, false) // only Data
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) // only Message *Alternative use
        {

        }
        public ErrorDataResult() : base(default, false) // empty result *Alternative use
        {

        }
    }
}
