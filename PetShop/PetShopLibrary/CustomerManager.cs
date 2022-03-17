using PetShopLibrary;
using System;

public class CustomerManager : IManager
{
	public List<Customer> Customers { get; set; } = new List<Customer>();
	public CustomerManager()
	{
	}

    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}
