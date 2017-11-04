namespace WerewolfSim2k17.Month_State
{
    public class February : MonthState
    {

        private Player.Player player;
        private Main.MainSim sim;

        public February(Player.Player player, Main.MainSim sim)
        {
            this.player = player;
            this.sim = sim;
        }

        /// <summary>
        /// Increases your constitution
        /// The Snow Moon
        /// </summary>
        public void fullMoon()
        {

        }

        /// <summary>
        /// Removes the buffs/debuffs of the snow moon
        /// </summary>
        public void removeMoon()
        {

        }

        /// <summary>
        /// Changes to the next month
        /// </summary>
        public void goNext()
        {
            removeMoon();
            sim.currState = new March(player, sim);
        }


    }
}