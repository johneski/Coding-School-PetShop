using System;

public enum FoodType
{
    Dry,
    Canned,
    Home_Cooked,
    Raw
    
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



