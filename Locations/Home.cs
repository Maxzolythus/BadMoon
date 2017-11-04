using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;

namespace WerewolfSimCSharp.Locations
{
    public class Home : Location
    {
        private Player _player;
        private MainSim _sim;
        
        public Home(Player player, MainSim sim)
        {
            _player = player;
            _sim = sim;
        }

        public void action()
        {
            // Stuff, check ref sheet
        }
    }
}