using System;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Shop
{
    public class Club : Shop
    {
        private static Player _player;
        private MainSim _sim;
        private Person _person;

        public Club(Player player, MainSim sim) : base(player)
        {
            _player = player;
            _sim = sim;
        }

        public override void action()
        {
            // Expensive Drinks and Food that slighty lower hunger
            // Aeyden is here every /odd/ day
            string act;
                    
            do
            {
                Console.WriteLine("1: Go get Food\n2: Dance");
                act = Console.ReadLine();
                if (checkInput(act)) break;
            } while(true);
            
            if (act == "1")
            {
                menu();
            }
            else
            {
                if (_sim.CurrState.currentDay() % 2 != 0) // Aeyden is here
                {
                    _person = new Aeyden(_player);
                    _person.clubAction();
                }
                else
                {
                    //TODO Add "Aeyden isn't here" dialouge
                }
            }
        }

        public override void menu()
        {
            string act;
            do
            {
                Console.WriteLine("1: Buy\n2: Sell");
                act = Console.ReadLine();
                if (checkInput(act)) break;
            } while(true);

            if (act == "1")
            {
                buy();
            }
            else
            {
                //TODO prompt for items to sell
            }
        }

        public override void buy()
        {
            throw new NotImplementedException();
        }

        private bool checkInput(string act)
        {
            int trainNum = Convert.ToInt32(act);
            return act != "" &&  trainNum >= 1 && trainNum <= 2;
        }
    }
}