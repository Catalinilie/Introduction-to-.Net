using System;

namespace Lab2
{
    public class Manager:Employee
    {
        public Manager( int id1, String FirstName1, String LastName1, DateTime StarDate1, DateTime EndDate1, int Salary1) : base(id1, FirstName1, LastName1, StarDate1, EndDate1, Salary1)
        {
        }


        public override String Salutation()
        {
            return "Hello manager";
        }
    }
}
