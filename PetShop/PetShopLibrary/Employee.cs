using System;

public class Employee : Person
{
	public decimal Salary { get; set; }
	public enum Type
    {
		CEO,
		Manager,
		Employee,
    }
	public Employee(string name, string surname,decimal salary):base(name, surname)
	{
		Salary = salary;
	}
}
