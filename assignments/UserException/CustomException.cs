using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments.UserException
{
    internal class CustomException
    {
        public static Dictionary<int, string> customMessageList =
            new Dictionary<int, string>()
            {

                {1, "Age should be between 0 and 120" },
                {2, "Patient name and Diagnosis cannot be null"},
                {3, "Treatment Cost cannot be null" }

            };
    }

    internal class AgeException : Exception
    {
        public AgeException(string? message) : base(message)
        {
        }
    }

    internal class InvalidPatientDataException : Exception
    {
        public InvalidPatientDataException(string? message) : base(message)
        {
        }
    }

    internal class InvalidMedicalRecordException : Exception
    {
        public InvalidMedicalRecordException(string? message) : base(message)
        {
        }
    }

}
