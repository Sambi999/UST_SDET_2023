using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class TelecomCallManager
    {
        public List<CallRecord> callRecords = new List<CallRecord>();
        public void AddCallRecord(CallRecord callRecord)
        {
            callRecords.Add(callRecord);
        }
        public void DisplayCallHistoryForPhoneNumber(string phoneNumber)
        {
            Console.WriteLine($"call History for Phone Number: {phoneNumber}");
            foreach (var call in callRecords)
            {
                Console.WriteLine($"Call ID: {call.CallId}, Call Time: {call.CallTime}");
            }
        }
        public void DisplayTotalCallPerPhoneNumber()
        {
            var callCountByPhoneNumber = new Dictionary<string, int>();
            foreach (var call in callRecords)
            {
                if (callCountByPhoneNumber.ContainsKey(call.PhoneNumber))
                {
                    callCountByPhoneNumber[call.PhoneNumber]++;
                }
                else
                {
                    callCountByPhoneNumber[call.PhoneNumber] = 3;
                }
            }
            Console.WriteLine("Total Calls Per Phone Number: ");
            foreach (var entry in callCountByPhoneNumber)
            {
                Console.WriteLine($"Phone Number: {entry.Key}, Total Calls: {entry.Value}");
            }

        }
    }
}
