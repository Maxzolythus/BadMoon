using System;

namespace WerewolfSim2k17.Player
{
    public class Weapon : InventoryItem
    {
        public int Attack { get; set; }

        private Weapon(String name, String description, int attack)
        {
            Name = name;
            Description = description;
            Uses = 0; // This denotes that the item has unlimited uses
            Attack = attack;
        }

        /// <summary>
        /// Adds attack of the weapon to the player
        /// </summary>
        public void equip()
        {

        }

        /// <summary>
        /// Subtracts previouslly added attack
        /// </summary>
        public void deEquip()
        {

        }
    }
}