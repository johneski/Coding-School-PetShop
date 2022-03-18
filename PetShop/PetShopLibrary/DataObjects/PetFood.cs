using PetShopLibrary;
using System;

public enum FoodType
{
    CatFood,
    DogFood,
    FishFood,
    ReptilianFood
}

public enum FoodBrand
{
    Pedigree,
    Friskis,
    Rats
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



