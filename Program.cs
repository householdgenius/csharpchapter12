using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company()
            {
                Name = "Planet Fitness"
            };

            
            // Create three employees
            Employee guy = new Employee()
            {
              FirstName = "Guy",
              LastName = "Fiari",
              Title = "Food Eater",
              StartDate = new DateTime(2021,11,17)  
            };
            // Assign the employees to the company
            myCompany.Employees.Add(guy);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
