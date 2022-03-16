using PetShopLibrary;
using System;

public class PetManager: IManager
{
    public  List<Pet> Pets { get; set; }

    public PetManager()
	{
	}

    public void Create()
    {
       throw new NotImplementedException(); 
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
