using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;
using WerewolfSimCSharp.NPCs;

namespace WerewolfSimCSharp.Locations
{
    public class Resturant : Location
    {
        private Player _player;
        private MainSim _sim;
        private Person _person;

        public Resturant(Player player, MainSim sim)
        {
            _player = player;
            _sim = sim;
        }
        
        public void action()
        {
            
        }
    }
}