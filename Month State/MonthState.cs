namespace WerewolfSim2k17.Month_State
{
    public interface MonthState
    {
        /// <summary>
        /// Gives buffs and debuffs based on the current month state
        /// </summary>
        void fullMoon();

        /// <summary>
        /// Removes whatever buffs/debuffs that were given
        /// </summary>
        void removeMoon();

        /// <summary>
        /// Changes to the next month
        /// For example August to September
        /// </summary>
        void goNext();

    }
}