using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class CallRecord
    {
        public CallRecord(int callId, string phoneNumber, DateTime callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime CallTime { get; set; }
        

    }
}
