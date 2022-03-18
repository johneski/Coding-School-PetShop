using System;

public enum FoodType
{
    Pedigree,
    Friskis,
    Rats
}

public interface IFood
{
    FoodType Food { get; set; }
}

    public class PetFood : IFood
    {
        public FoodType Food { get; set; }



        public PetFood()
        {

        }

    }



