using System.ComponentModel.DataAnnotations;
using Classes;

// Person firstPerson = new();
Customer firstCustomer = new("Marty", "Flaherty", "1234567890", "mflaherty@elevenfifty.org", true);
Customer secondCustomer = new("Ben", "Strycker", "2345678901", "ben@elevenfifty.org", true);
Customer thirdCustomer = new("Sam", "Gerry", "3456789012", "sam@elevenfifty.org", false);
Customer eighthCustomer = new("Kyle", "Lewis", "0987654321", "mflaherty@elevenfifty.org", true);
HourlyEmployee hourMan = new();
SalaryEmployee salaryMan = new();

List<Person> peopleList = new();
peopleList.Add(firstCustomer);
peopleList.Add(hourMan);
peopleList.Add(salaryMan);
peopleList.Add(secondCustomer);


namespace Classes
{
    public abstract class Person
    {
        public Person() {}

        public Person(string firstName, string lastName, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Customer : Person
    {
        public Customer(string firstName, string lastName, string phone, string email, bool isPremium) 
            : base(firstName, lastName, phone, email)
        {
            IsPremium = isPremium;
        }

        public bool IsPremium { get; set; }
    }

    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
    }

    public class HourlyEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyWage { get; set; }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}