using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop2
{
    public enum Gender { Male, Female }
    public enum SecurityLevel { guest, Developer, secretary , DBA }

    public class Employee
    {
        // this is the answer of question 1 in part 3
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private DateTime hireDate;
        private Gender gender;

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, Gender gender)
        {
            this.id = id;
            this.name = name;
            this.securityLevel = securityLevel;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }

        public int ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Security Level: {securityLevel}, Salary: {salary:C}, Hire Date: {hireDate:d}, Gender: {gender}";
        }
    }
}
