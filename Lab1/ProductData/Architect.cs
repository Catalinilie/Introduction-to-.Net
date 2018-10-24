using System;

namespace ProductData
{
    public class Architect
    {
        public int id;
        public String FirstName;
        public String LastName;
        public DateTime StartDate;
        public DateTime EndDate;
        public double salary;

        public String GetFullName(){
            return FirstName + " " + LastName;
        }
        public bool IsActive(){
                if(StartDate<EndDate)
                return true;
                else 
                return false;
        }
    }
}
