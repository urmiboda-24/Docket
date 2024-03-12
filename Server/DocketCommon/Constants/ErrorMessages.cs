using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocketCommon.Constants
{
    public class ErrorMessages
    {
        private ErrorMessages() { }

        public const string PAGE_SIZE = "Page size must be greater than or equal to 1.";

        public const string PAGE_NUMBER = "Page number must be greater than or equal to 1.";

        public const string TRANSACTION_IS_ALREADY_RUNNING = "A transaction is already in progress.";
    }
    public static class ExceptionMessage
    {
        public const string INTERNAL_SERVER = "An error occurred while processing the request";

        public const string INVALID_MODELSTATE = "Invalid Entry";

    }
}