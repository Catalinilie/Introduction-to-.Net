using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public abstract class Employee
    {
        public Employee(int id1, String lastName, String firstName, DateTime startDate, DateTime endDate, int salary)
        {
            id = id1;
            LastName = lastName;
            FirstName = firstName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }
        protected int id;

        public String LastName { get; private set; }

        protected String FirstName { get; private set; }

        protected DateTime StartDate { get; private set; }

        protected DateTime EndDate { get; private set; }

        protected int Salary { get; private set; }

        public String GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsActive(DateTime currentTime)
        {
            if (currentTime > StartDate && currentTime < EndDate)
                return true;
            else
                return false;
        }

        public abstract String Salutation();
    }
}
