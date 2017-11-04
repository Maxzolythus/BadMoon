using System;
using System.Security.Cryptography;
using WerewolfSim2k17.Player;

namespace WerewolfSimCSharp.Views
{
    public class Food : Item
    {
        private Player _player;
        private int _healthRestore;
        private int _hungerRestore;
        
        public Food(string name, string description, int sellPrice, int buyPrice, int healthRestore, Player player) : base(name,
            description, sellPrice, buyPrice, player)
        {
            _healthRestore = healthRestore;
            _hungerRestore = healthRestore * 2;
            _player = player;
        }

        public override void use()
        {
            _player.stats["Health"] += _healthRestore;
            _player.stats["Hunger"] -= _hungerRestore;
        }
    }
}