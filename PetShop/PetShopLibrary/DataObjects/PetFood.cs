using PetShopLibrary;
using System;

public enum FoodType
{
    CatFood,
    DogFood,
    FishFood,
    ReptilianFood,
    BirdFood
}

public enum FoodBrand
{
    Pedigree,
    Friskis,
    Purina,
    Royal,


}

public interface IFood
{
    FoodType Type { get; set; }
}

public class PetFood : Product, IFood
{
    public FoodType Type { get; set; }

    public FoodBrand Brand { get; set; }

    public PetFood()
    {

    }

}


