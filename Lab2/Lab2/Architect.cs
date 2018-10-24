using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Architect:Employee
    {

        public Architect(int id1, String FirstName1, String LastName1, DateTime StarDate1, DateTime EndDate1, int Salary1):base(id1,FirstName1,LastName1,StarDate1,EndDate1,Salary1)
        {
        }


        public override String Salutation()
        {
            return "Hello architect";
        }
    }
}
