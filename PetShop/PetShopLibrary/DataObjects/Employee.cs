using System;

public enum EmployeeType
{
	CEO,
	Manager,
	Employee,
}

public interface IEmployee
{
	EmployeeType Type { get; set; }

}
public class Employee : Person, IEmployee
{
	public decimal Salary { get; set; }
	public EmployeeType Type { get; set; }

	public Employee()
    {

    }
	public Employee(string name, string surname,decimal salary):base(name, surname)
	{
		Salary = salary;
	}
}
