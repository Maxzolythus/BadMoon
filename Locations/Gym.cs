using System;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Locations
{
    public class Gym : Location
    {

        private Player _player;
        private MainSim _sim;
        private Person _person;
        
        public Gym(Player player, MainSim sim)
        {
            _player = player;
            _sim = sim;
        }
        
        /// <summary>
        /// The actions for going to the gym
        /// </summary>
        public void action()
        {
            // Strength train, Agility train, Endurance train, Freya, or Douchebro.
            
            //TODO Prompt for which training style
            
            string train;
                       
            do
            {
                Console.WriteLine("1: Hit the weights\n2: Take a run\n3: Condition yourself for the elements");
                train = Console.ReadLine();
                if (checkInput(train)) break;
            } while(true);
            
            
            if (train == "1")
            {
                if (_sim.CurrState.currentDay() % 3 == 0) // Douchebro
                {
                    _person = new Chris(_player);
                    _person.gymAction();
                }
                else if (_sim.CurrState.currentDay() % 2 == 0) // Freya
                {
                    _person = new Diana(_player);
                    _person.gymAction();
                }
                else
                {
                    if (_player.stats["Str"] <= 5)
                    {
                        Console.WriteLine("You guess being a werewolf doesn't make you instantly stronger...");
                        Console.WriteLine("Despite how much you wish it would...");

                        _player.statsExp["Str"]++;
                    }
                    else
                    {
                        Console.WriteLine("stronk"); // TODO change dialouge
                        _player.statsExp["Str"]++;
                    }
                }
            }
            else if (train == "2")
            {
                if (_sim.CurrState.currentDay() % 5 == 0) // Then douchebro is doing cardio
                {
                    _person = new Chris(_player);
                    _person.gymAction();
                }
                else
                {
                    if (_player.stats["Dex"] <= 5)
                    {
                        Console.WriteLine("You feel out of breath...");
                        _player.statsExp["Dex"]++;

                    }
                    else
                    {
                        Console.WriteLine("Your speed is unrivaled!");
                        Console.WriteLine("You wonder if being the first werewolf track star is out of the question?");
                        _player.statsExp["Dex"]++;
                    }
                }
            }
            else
            {
                if (_sim.CurrState.currentDay() % 5 == 0) // Then Freya is doing conditioning
                {
                    _person = new Diana(_player);
                    _person.gymAction();
                }
                else
                {
                    if (_player.stats["Con"] <= 5)
                    {
                        Console.WriteLine("You feel out of breath...");
                        _player.statsExp["Con"]++;

                    }
                    else
                    {
                        Console.WriteLine("You're starting to hold your own!");
                        _player.statsExp["Con"]++;
                    }
                }
            }
        }

        private bool checkInput(string train)
        {
            int trainNum = Convert.ToInt32(train);
            return train != "" &&  trainNum >= 1 && trainNum <= 3;
        }
    }
}