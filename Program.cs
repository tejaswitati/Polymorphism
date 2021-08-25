using System;

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Employee(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}

class Developer:Employee
{
    string _skills;
    public Developer(string firstName, string lastName, string skills):base(firstName, lastName)
    {
        _skills = skills;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Developer d = new Developer("Sowmya", "V", "C++");
    }
}