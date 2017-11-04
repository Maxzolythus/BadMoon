using System;
using System.ComponentModel.Design;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Locations
{
    public class Mall : Shop.Shop
    {
        private Player _player;
        private MainSim _sim;
        private Person _person;

        public Mall(Player player, MainSim sim) : base(player)
        {
            _player = player;
            _sim = sim;
        }

        public override void action()
        {
            //TODO 1: Shop 2: Fast Food
            string act;
            do
            {
                Console.WriteLine();
                act = Console.ReadLine();
                if (checkInput(act)) break;
            } while (true);

            if (act == "1")
            {
                if (_sim.CurrState.currentDay() % 2 == 0) // Aeyden is here
                {
                    _person = new Aeyden(_player);
                    _person.mallAction();
                }
                //menu()
            }
            else
            {
                
            }
        }
        
        private bool checkInput(string act)
        {
            int actNum = Convert.ToInt32(act);
            return act != "" &&  actNum >= 1 && actNum <= 2;
        }
    }
}