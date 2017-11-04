using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Locations
{
    public class Howl : Location
    {
        private Player _player;
        private MainSim _sim;
        private Person _person;

        public Howl(Player player, MainSim sim)
        {
            _player = player;
            _sim = sim;
        }

        public void action()
        {
            // TODO Quest board, Shop, Socialize (Steve is always on the compound)
            
        }
    }
}