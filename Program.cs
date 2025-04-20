using System;

namespace EmployeeComparisonApp
{
    // Employee class with Id, FirstName, and LastName properties
    class Employee
    {
        public int Id { get; set; }           // Unique identifier for the employee
        public string FirstName { get; set; } // First name of the employee
        public string LastName { get; set; }  // Last name of the employee

        // Overload the '==' operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are same instance, return true
            if (ReferenceEquals(emp1, emp2)) return true;

            // If one is null, return false
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;

            // Compare the Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator, required as a pair with '=='
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Negate the result of the '==' operator
        }

        // Override Equals and GetHashCode to prevent compiler warnings
        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee object and assign properties
            Employee employee1 = new Employee()
            {
                Id = 101,
                FirstName = "John",
                LastName = "Doe"
            };

            // Create the second employee object and assign properties
            Employee employee2 = new Employee()
            {
                Id = 102,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two employee objects using the overloaded '=='
            if (employee1 == employee2)
            {
                Console.WriteLine("Both employees have the same ID.");
            }
            else
            {
                Console.WriteLine("Employees have different IDs.");
            }

            // Compare the two employee objects using the overloaded '!='
            if (employee1 != employee2)
            {
                Console.WriteLine("Confirmed: The employees are not the same.");
            }
            else
            {
                Console.WriteLine("Confirmed: The employees are the same.");
            }

            // Wait for user to press Enter before closing the console
            Console.ReadLine();
        }
    }
}
