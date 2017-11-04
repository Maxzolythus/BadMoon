using System.Runtime.InteropServices;
using WerewolfSim2k17.Player;

namespace WerewolfSimCSharp.Views
{
    public abstract class Item
    {
        private int _sellPrice;
        private int _buyPrice;
        private Player _player;
        public string Name { get; private set; }
        public string Description { get; private set; }


        public Item(string name, string description, int sellPrice, int buyPrice, Player player)
        {
            Name = name;
            Description = description;
            _sellPrice = sellPrice;
            _buyPrice = buyPrice;
            _player = player;
        }
        
        
        public abstract void use();
   

        public int BuyPrice
        {
            get { return _buyPrice; }

            set { _sellPrice = value; }
        }

        public int SellPrice
        {
            get { return _sellPrice; }
            
            set { _buyPrice = value; }
        }
        
        public override string ToString()
        {
            return Description;
        }
    }
}