using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{

    internal class MedicalHistory
    {
        public int RecordId { get; set; }
        public int PatientId { get; set; }

        public string? Description { get; set; }

        public DateTime Date { get; set; }
        List<MedicalHistory> MHList { get; set; } = new List<MedicalHistory>();
        public void AddMedicalHistoryToFile(MedicalHistory medicalHistory)
        {
            FileStream fileStream = new FileStream("D:\\Training Handson\\Basic Solution\\assignments\\Sample.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            MHList.Add(medicalHistory);
            Console.WriteLine("Medical History added");

            streamWriter.WriteLine("Patient ID: " + medicalHistory.PatientId);
            streamWriter.WriteLine("Record ID : " + medicalHistory.RecordId);
            streamWriter.WriteLine("Description: " + medicalHistory.Description);
            streamWriter.WriteLine("Date: " + medicalHistory.Date);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
        public void ReadMedicalHistoryFromFile(int patientID)
        {
            if (PatientId == patientID)
            {
                FileStream fileStream = new FileStream("D:\\Training Handson\\Basic Solution\\assignments\\Sample.txt", FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string? str = streamReader.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = streamReader.ReadLine();
                }
                streamReader.Close();
                fileStream.Close();

            }
            else
            {
                Console.WriteLine("Patient ID doesn't exist");
            }
        }


    }   
        
    
}
