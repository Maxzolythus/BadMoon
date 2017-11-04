using System;
using System.Collections.Generic;

namespace WerewolfSim2k17.Player
{
    public class Inventory
    {
        public double Money { get; set; }
        public Dictionary<String, InventoryItem> Bag { get; set; }

        /// <summary>
        /// Adds an item to the player's inventory
        /// </summary>
        /// <param name="newItem"></param>
        public void addItem(InventoryItem newItem)
        {
                Bag.Add(newItem.Name, newItem);
        }

        /// <summary>
        /// Uses item and removes it from inventory WHAT IF I WANT AN ITEM WITH MULTIPLE USES
        /// </summary>
        /// <param name="item"></param>
        public void useItem(InventoryItem item)
        {
            item.use();
            if (item.Uses == 1)
            {
                Bag.Remove(item.Name);
            }
        }

    }
}