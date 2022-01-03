using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    public class Manager
    {
        public string FName;
        public string LName;
        public string BirthDay;
        public string Email;

        public Manager(string fName, string lName, string birthDay, string email)
        {
            FName = fName;
            LName = lName;
            BirthDay = birthDay;
            Email = email;
        }
    }
}
