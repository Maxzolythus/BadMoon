using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Security;
using System.Security.Policy;

namespace WerewolfSim2k17.Player
{
    public class Player
    {
        private String name;
        private String[] pronouns;
        public Dictionary<String, int> stats { get; set; }
        private int lvl;

        public Player(String name, String[] pronouns, Dictionary<String, int> stats)
        {
            this.name = name;
            this.pronouns = pronouns;
            
            // Have stats be chooseable in the beginning dialouge
            this.stats = stats;
     
            lvl = 1;
        }

        public Player(String name, String[] pronouns)
        {
            this.name = name;
            this.pronouns = pronouns;

            lvl = 1;
            
            // "Deprivated" stats
            this.stats.Add("Str", 5);
            this.stats.Add("Con", 5);
            this.stats.Add("Int", 5);
            this.stats.Add("Attack", this.stats["Str"] + 2); // Strenght multiplier + weapon attack
            this.stats.Add("Ctrl", 70);
            this.stats.Add("Karma", 50);
            this.stats.Add("Hunger", 0);
            this.stats.Add("Masquerade", 90);
            this.stats.Add("Max Health", 120);
            this.stats.Add("Curr Health", 120);
        }

        public void levelUp()
        {

        }

        /// <summary>
        /// Verifies if the player is dead
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            return stats["Curr Health"] < 0;
        }
    }
}