using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace WerewolfSim2k17.Main
{
    public class MainSim
    {
        public Month_State.MonthState currState { get; set; }
        public int Year { get; set; }
        private static Player.Player _player;

        public static void NewGame()
        {
            // TODO use cutscene function to grab dialouge for name, pronouns, and stats
            Console.WriteLine("Enter your name \n>");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your pronouns \n>");
            String pronounStr = Console.ReadLine();

            String[] pronouns = pronounStr.Split(new char[] {','});

            Console.WriteLine("Stat number \n>");

            do
            {
                String statNum = Console.ReadLine();

                Dictionary<String, int> stats = new Dictionary<string, int>();

                if (statNum.Equals("1")) // Strong
                {
                    stats.Add("Str", 7);
                    stats.Add("Con", 6);
                    stats.Add("Int", 3);
                    stats.Add("Attack", stats["Str"] + 2); // Strenght multiplier + weapon attack
                    stats.Add("Ctrl", 90);
                    stats.Add("Karma", 0);
                    stats.Add("Hunger", 0);
                    stats.Add("Masquerade", 100);
                    stats.Add("Max Health", 110);
                    stats.Add("Curr Health", 110);
                    _player = new Player.Player(name, pronouns, stats);
                    break;
                }
                else if (statNum.Equals("2")) // Agile
                {
                    stats.Add("Str", 4);
                    stats.Add("Con", 4);
                    stats.Add("Int", 5);
                    stats.Add("Attack", stats["Str"] + 1); // Strenght multiplier + weapon attack
                    stats.Add("Ctrl", 100);
                    stats.Add("Karma", 0);
                    stats.Add("Hunger", 0);
                    stats.Add("Masquerade", 140);
                    stats.Add("Max Health", 90);
                    stats.Add("Curr Health", 90);
                    _player = new Player.Player(name, pronouns, stats);
                    break;
                }
                else if (statNum.Equals("3")) // Witty
                {
                    stats.Add("Str", 3);
                    stats.Add("Con", 4);
                    stats.Add("Int", 7);
                    stats.Add("Attack", stats["Str"] + 1); // Strenght multiplier + weapon attack
                    stats.Add("Ctrl", 150);
                    stats.Add("Karma", 0);
                    stats.Add("Hunger", 0);
                    stats.Add("Masquerade", 120);
                    stats.Add("Max Health", 100);
                    stats.Add("Curr Health", 100);
                    _player = new Player.Player(name, pronouns, stats);
                    break;
                }
                else if (statNum.Equals("-666")) // D E P R I V E D 
                {
                    _player = new Player.Player(name, pronouns);
                }
            }
        } while(true);

    }

        public void ResumeGame()
        {
            
        }

        public void PlayGame()
        {
            
        }

        private void Cutscene()
        {
              
        }

        public static void Main()
        {
            NewGame();
        }
        
    }
}