using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class Employee
    {
        #region Attributes
        private char _gender;
        private HiringDate _hireDate;
        #endregion
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }


        public char Gender
        {
            get { return _gender; }
            set
            {
                if (value == 'M' || value == 'F' || value == 'm' || value == 'f')
                {
                    _gender = char.ToUpper(value);
                }
                else
                {
                   Console.WriteLine("Gender must be either 'M' or 'F'.");
                }
            }
        }
        #endregion
        #region constructor
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char _gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = _gender;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return string.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
                Id, Name, SecurityLevel, Salary, HireDate.ToString(), Gender);
        }
        #endregion
    }

}
