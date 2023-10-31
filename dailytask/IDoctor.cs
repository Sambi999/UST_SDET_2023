using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface IDoctor
    {
        void AddNewDoctor(int did, string? dname);
        
        void ModifyDoctor(int did, string? dname);
    }
}
