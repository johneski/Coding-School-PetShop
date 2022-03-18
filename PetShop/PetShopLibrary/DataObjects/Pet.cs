using System;



public enum AnimalType
{
    Bird,
    Reptilian,
    Mammal,
    Fish

}


public enum PetFoodType
{
    CatFood,
    DogFood,
    FishFood,
    ReptilianFood
}

public enum PetStatus
{
    OK,
    Unhealthy,
    Recovering
}

public interface IPet
{
    PetFoodType FoodType { get; set; }
    PetStatus Status { get; set; }
    AnimalType AnimalType { get; set; }
    string Breed { get; set; }

}

public class Pet : IPet 
{
    public PetFoodType FoodType { get; set; }
    public PetStatus Status { get; set; }
    public AnimalType AnimalType { get; set; }
    public string Breed { get; set; }
    

    public Pet()
	{
    }
}

