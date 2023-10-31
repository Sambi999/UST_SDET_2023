using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff : StaffDetails
    {
        public string? specializations { get; set; }
        public int sem {  get; set; }
        public void DsiplayTStaffDetails()
        {
            Console.WriteLine("Spec: {0} \n Sem: {1}", specializations, sem);

        }
    
    }
}
