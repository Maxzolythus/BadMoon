using System;
using System.Runtime.InteropServices;

namespace WerewolfSim2k17.Player
{
    public abstract class InventoryItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public int Uses { get; set; }

        /// <summary>
        /// What happens when you use an item
        /// </summary>
        public void use()
        {
            Console.WriteLine("Can't be used.");
        }
    }
}