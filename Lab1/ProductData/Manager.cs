using System;

namespace ProductData
{
    public abstract class Manager
    {
        public Manager(int id1, String FirstName1, String LastName1, DateTime StartDate1, double salary1)
        {
            id = id1;
            FirstName = FirstName1;
            LastName = LastName1;
            StartDate = StartDate1;
            EndDate = DateTime.Now;
            salary = salary1;
        }
        public int id;
        public String FirstName;
        public String LastName;
        public DateTime StartDate;
        public DateTime EndDate;
        public double salary;
        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public bool IsActive()
        {
            if (StartDate < EndDate)
                return true;
            else
                return false;
        }
    }
}
