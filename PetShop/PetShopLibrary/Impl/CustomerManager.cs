using PetShopLibrary;
using System;

public interface ICustomerValidator
{
	bool ValidateTin(string s);
}

public interface IPersonValidator
{
	bool ValidateName(string s);
	bool ValidateLastName(string s);
}


public class CustomerValidator : ICustomerValidator
{
    public bool ValidateTin(string s)
    {
		throw new NotImplementedException();
	}
}

public class CustomerManager 
{
	private ICustomerValidator _validator;
	public List<Customer> Customers { get; set; } = new List<Customer>();
	public CustomerManager(ICustomerValidator validator)
	{
		_validator = validator;
	}

    public bool ValidateTIN(string s)
    {
		throw new NotImplementedException();
    }
}
