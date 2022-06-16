using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensusAnalyser
{
    internal class CustomExceptions : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, INVALID_FILE
        }
        ExceptionType Type;
        public CustomExceptions(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
