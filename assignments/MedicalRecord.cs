using assignments.UserException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class MedicalRecord : Patient
    {
        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }

        public static List<MedicalRecord> MedicalRecordList { get; set; } = new List<MedicalRecord>();

        public void AddMedicalRecord(int recordId, int id, string name, int age, string diagnosis, double treatmentCost)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(diagnosis))
            {
                throw new InvalidPatientDataException(CustomException.customMessageList[4]);
            }
            else if (treatmentCost < 0)
            {
                throw new InvalidMedicalRecordException(CustomException.customMessageList[5]);
            }
            else
            {
                MedicalRecordList.Add(new MedicalRecord { RecordId = recordId, PatientID = id, PatientName = name, Age = age, Diagnosis = diagnosis, TreatmentCost = treatmentCost });
            }
        }
        public void DisplayDetails()
        {
            foreach (var item in MedicalRecordList)
            {
                Console.WriteLine("RecordId:" + item.RecordId);
                Console.WriteLine("Id:" + item.PatientID);
                Console.WriteLine("Name:" + item.PatientName);
                Console.WriteLine("Age:" + item.Age);
                Console.WriteLine("Diagnosis:" + item.Diagnosis);
                Console.WriteLine("TreatmentCost:" + item.TreatmentCost);
            }
        }

    }
}
