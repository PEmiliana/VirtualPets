using System;
namespace VirtualPets
{
    public class Pet
    {
        public int Health { set; get; }
        public int Mood { set; get; }
        public int Hunger { get; set; }

public Pet()
        {
            Health = 100;
            Mood = 100;
            Hunger = 0;
        }
        public void Update()
        {

            if (Hunger <= 0)
            { Hunger = 0; }
        }

    }

}
