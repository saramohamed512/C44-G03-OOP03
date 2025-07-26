namespace Assignment3_OOP
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
            //HiringDate hiringDate1= new HiringDate();
            //Console.WriteLine(hiringDate1);
            //HiringDate hiringDate2 = new HiringDate(5,12,2000);
            //Console.WriteLine(hiringDate2);
            //Employee employee = new Employee(1, "John Doe", SecurityLevel.Developer, 60000.00m, hiringDate2, 'M');
            //Console.WriteLine(employee);
            #endregion
            #region problem3
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Alice Smith", SecurityLevel.Developer, 75000.00m, new HiringDate(15, 6, 2015), 'F');
            employees[1] = new Employee(2, "Bob Johnson", SecurityLevel.Secretary, 90000.00m, new HiringDate(20, 3, 2020), 'M');
            employees[2] = new Employee(3, "Charlie Brown", SecurityLevel.Guest, 50000.00m, new HiringDate(10, 1, 2018), 'M');
            //Console.WriteLine("Employees List:");
            //Console.WriteLine("--------------------------------------------------");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //     Console.WriteLine("----------------------------");
            //}

            #endregion
            #region problem4
            // Sort by hire date
            //var sortedEmployees = employees.OrderBy(e => e.HireDate.ToDateTime()).ToArray();

            //Console.WriteLine("Employees sorted by hire date:");
            //Console.WriteLine("--------------------------------------------------");
            //foreach (var emp in sortedEmployees)
            //{
            //    Console.WriteLine(emp);

            //    Console.WriteLine("----------------------------");
            //}
            #endregion
            #region problem5

            //List<Book> library = new List<Book>();

            //library.Add(new EBook("C# Programming", "John Sharp", "978-1234567890", 5.2, "PDF"));
            //library.Add(new PrintedBook("Clean Code", "Robert Martin", "978-0132350884", 464, "Hardcover"));
            //library.Add(new EBook("Design Patterns", "Erich Gamma", "978-0201633610", 3.8, "EPUB"));
            //library.Add(new PrintedBook("The Pragmatic Programmer", "Andrew Hunt", "978-0201616224", 352, "Paperback"));


            //Console.WriteLine("Library Catalog:");
            //Console.WriteLine("--------------------------------------------------");

            //foreach (var book in library)
            //{
            //    Console.WriteLine(book);
            //    Console.WriteLine("----------------------------");
            //}


            #endregion


        }
    }
}
