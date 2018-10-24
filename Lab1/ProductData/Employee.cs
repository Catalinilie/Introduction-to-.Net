using System;

namespace ProductData
{
    public class Employee : Manager
    {
        public Employee(int id1, String FirstName1, String LastName1, DateTime StartDate1, double salary1) : base(id1,FirstName1,LastName1,StartDate1,salary1)
        {
        }
    }
}