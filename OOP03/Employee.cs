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
        private int _id;
        private string _name;
        private SecurityLevel _securityLevel;
        private decimal _salary;
        private HiringDate _hireDate;
        private char _gender;
        #endregion

        #region Properties with Validation
        public int Id
        {
            get => _id;
            set => _id = value > 0 ? value : throw new ArgumentException("ID must be positive");
        }

        public string Name
        {
            get => _name;
            set => _name = !string.IsNullOrWhiteSpace(value) ? value.Trim() :
                throw new ArgumentException("Name cannot be empty");
        }

        public SecurityLevel SecurityLevel
        {
            get => _securityLevel;
            set => _securityLevel = Enum.IsDefined(typeof(SecurityLevel), value) ? value :
                throw new ArgumentException("Invalid security level");
        }

        public decimal Salary
        {
            get => _salary;
            set => _salary = value >= 0 ? value :
                throw new ArgumentException("Salary cannot be negative");
        }

        public HiringDate HireDate
        {
            get => _hireDate;
            set => _hireDate = value ?? throw new ArgumentNullException("Hire date cannot be null");
        }

        public char Gender
        {
            get => _gender;
            set => _gender = char.ToUpper(value) switch
            {
                'M' or 'F' => char.ToUpper(value),
                _ => throw new ArgumentException("Gender must be 'M' or 'F'")
            };
        }
        #endregion

        #region Constructors
    
        public Employee() : this(1, "null", SecurityLevel.Guest, 0, new HiringDate(), 'M') { }

       
        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }


        #endregion

        #region Methods
        public override string ToString()
        {
           return  $"ID: {Id}\nName: {Name}\nSecurity Level: {SecurityLevel}\n" +
            $"Salary: {Salary:C}\nHire Date: {HireDate}\nGender: {Gender}";
        }

    
        #endregion
    }

}
