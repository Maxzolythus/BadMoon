using System;

namespace WerewolfSim2k17.Month_State
{
    public class January : MonthState
    {
        private Player.Player player;
        private Main.MainSim sim;


        public January(Player.Player player, Main.MainSim sim)
        {
            this.player = player;
            this.sim = sim;
        }

        /// <summary>
        /// Increases your strenght, lowers your control
        /// The Wolf Moon
        /// </summary>
        public void fullMoon()
        {

        }

        /// <summary>
        /// Removes the buffs/debuffs of the wolf moon
        /// </summary>
        public void removeMoon()
        {

        }

        /// <summary>
        /// Changes to the next month
        /// For example August to Septemberq
        /// </summary>
        public void goNext()
        {
            removeMoon();
            sim.currState = new February(player, sim);
        }

    }
}