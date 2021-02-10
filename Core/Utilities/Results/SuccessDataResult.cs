using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base (data,true,message) // Data and message
        {

        }
        public SuccessDataResult(T data) : base (data,true) // only Data
        {

        }

        public SuccessDataResult(string message) : base (default,true,message) // only Message
        {

        }
        public SuccessDataResult() : base (default,true) // empty result
        {

        }
    }
}
