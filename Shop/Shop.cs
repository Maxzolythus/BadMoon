using System.Collections.Generic;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.Locations;
using WerewolfSimCSharp.Views;

namespace WerewolfSimCSharp.Shop
{
    public abstract class Shop : Location
    {
        private Player _player;
        
        public Shop(Player player)
        {
            _player = player;
        }
        
        public abstract void action();
        
        /// <summary>
        /// The shop's menu, typically a prompt for buy, sell, or chat with the shopkeeper
        /// </summary>
        public abstract void menu();
        
        /// <summary>
        /// Buying an object from the seller's inventory
        /// </summary>
        public abstract void buy();
        
        /// <summary>
        /// Sell an item in the player's inventory
        /// </summary>
        /// <param name="item">The item to sell</param>
        public void sell(Item item)
        {
            _player.Money += item.SellPrice;
            _player.removeItem(item);
        }
    }
}