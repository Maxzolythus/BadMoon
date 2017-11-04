using System;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Locations
{
    public class Library : Location
    {
        private Player _player;
        private MainSim _sim;
        private Person _person;

        public Library(Player player, MainSim sim)
        {
            _player = player;
            _sim = sim;
        }

        public void action()
        {
            // Bookie, Beary, Ghostie plus science

            string act;
            Console.WriteLine("1:Study\n2:Tutoring\n3:Read");

            do
            {
                act = Console.ReadLine();
             
                if (checkInput(act)) break;
            } while (true);

            if (act == "1")
            {
                // Science
            }
            else if (act == "2")
            {
                // Bear
               _person = new Eduardo(_player);
               _person.libraryAction();
            }
            else
            {
                if (_sim.CurrState.currentDay() % 2 == 0)
                {
                    // Emil
                }
                else
                {
                    // Just read a book
                }
            }
        }

        private bool checkInput(string input)
        {
            int inputNum = Convert.ToInt32(input);
            return input != "" && inputNum >= 1 && inputNum <= 3;
        }
    }
}