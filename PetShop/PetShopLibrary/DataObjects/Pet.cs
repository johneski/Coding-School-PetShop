using System;



public enum AnimalType
{
    Bird,
    Reptilian,
    Mammal

}


public enum PetFoodType
{
    CatFood,
    DogFood,
    FishFood
}

public enum PetStatus
{
    OK,
    Unhealthy,
    Recovering
}

internal interface IPet
{
    PetFoodType Type { get; set; }
    PetStatus Status { get; set; }
    AnimalType AnimalType { get; set; }
    string Breed { get; set; }

}

public class Pet : IPet 
{
    public PetFoodType Type { get; set; }
    public PetStatus Status { get; set; }
    public AnimalType AnimalType { get; set; }
    public string Breed { get; set; }
    

    public Pet()
	{
	}
}
