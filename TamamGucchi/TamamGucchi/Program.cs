using System;

namespace TamamGucchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TamamGucci pet");
            Console.WriteLine("Write a name for your pet");
            string Name = Console.ReadLine();
            Console.Clear();

            Tamagotchi tamamgucci = new Tamagotchi();
            Random generator = new Random();

            while (tamamgucci.Health > 0)
            {
                Console.WriteLine("TamamGucci pet");
                Console.WriteLine("Pet Name: " + Name);
                Console.WriteLine("Health: " + tamamgucci.Health);
                Console.WriteLine("Hunger: " + tamamgucci.Hunger);
                Console.WriteLine("Money: " + tamamgucci.Money);
                Console.ReadLine();

                //Daily Code

                tamamgucci.Boredom = generator.Next(1, 10);
                tamamgucci.Health = tamamgucci.Health - tamamgucci.Boredom;

                Console.WriteLine(Name + " Took daily damage " + tamamgucci.Boredom);

                tamamgucci.HungerTake = generator.Next(1, 5);
                tamamgucci.Hunger = tamamgucci.Hunger - tamamgucci.HungerTake;

                Console.WriteLine(Name + " Lost " + tamamgucci.HungerTake + " in hunger");


                Console.ReadLine();
                tamamgucci.Money = generator.Next(5, 10);
                Console.WriteLine(Name + " got " + tamamgucci.Money + " Money");

                Console.ReadLine();
                Console.Clear();

                //Shop Code

                Console.WriteLine("TamamGucci pet");
                Console.WriteLine("Pet Name: " + Name);
                Console.WriteLine("Health: " + tamamgucci.Health);
                Console.WriteLine("Money: " + tamamgucci.Money);

                Console.WriteLine("Welcome to Tamam Shop");
                Console.WriteLine("Type the thing you want");
                Console.WriteLine("Food: 10 Money");
                Console.WriteLine("Health Boost: 10 Money");
                tamamgucci.Shop = Console.ReadLine();


                if (tamamgucci.Shop == "Food")
                {
                    tamamgucci.Hunger = tamamgucci.Hunger + 2;
                    tamamgucci.Money = tamamgucci.Money - 10;
                }

                else if (tamamgucci.Shop == "Health Boost")
                {
                    tamamgucci.Health = tamamgucci.Health + 10;
                    tamamgucci.Money = tamamgucci.Money - 10;
                }
                else
                {
                    Console.WriteLine("Skipped");
                }

                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
