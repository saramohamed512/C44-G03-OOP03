namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1:
            //Employee employee = new Employee(1, "John Doe", SecurityLevel.Developer, 60000.00m, DateTime.Now, 'M');
            //Console.WriteLine(employee);
            //employee.Gender = 'X';
            //Console.WriteLine(employee);
            #endregion
            #region problem2
            HiringDate hiringDate1= new HiringDate();
            Console.WriteLine(hiringDate1);
            HiringDate hiringDate2 = new HiringDate(5,12,2000);
            Console.WriteLine(hiringDate2);
            Employee employee = new Employee(1, "John Doe", SecurityLevel.Developer, 60000.00m, hiringDate2, 'M');
            Console.WriteLine(employee);
            #endregion


        }
    }
}
