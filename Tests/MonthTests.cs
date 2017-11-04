using NUnit.Framework;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Month_State;
using WerewolfSim2k17.Player;

namespace WerewolfSimCSharp.Tests
{
    [TestFixture]
    public class MonthTests
    {
        /// <summary>
        /// Tests if months change as expected
        /// </summary>
        [Test]
        public void changeMonth()
        {
            Player player = new Player("Max", new string[]{"he","him","his"});
            MainSim sim = new MainSim();
            MonthState month = new January(player, sim);
            sim.CurrState = month;
            
            month.GoNext();
            
            Assert.IsTrue(sim.CurrState.GetType() == typeof(February));
        }
        
        /// <summary>
        /// Checks if the buffs apply, and remove themselves accordingly
        /// </summary>
        [Test]
        public void testBuffs()
        {
            Player player = new Player("Max", new string[]{"he","him","his"});
            MainSim sim = new MainSim();
            sim.CurrState = new January(player, sim);
            sim.Player = player;
            sim.CurrState.FullMoon();
            
            Assert.AreEqual(6, sim.Player.stats["Str"]); // Asserts added effects of Jan
            
            sim.CurrState.GoNext();

            Assert.AreEqual(5, sim.Player.stats["Str"]); // Asserts effects of Jan are gone
            
            sim.CurrState.FullMoon();
            
            Assert.AreEqual(6, sim.Player.stats["Con"]); // Asserts added effects of Feb
        }

         /// <summary>
         /// Checks if year increments after 12 months of gameplay
         /// </summary>
        [Test]
        public void newYear()
        {
            Player player = new Player("Max", new string[]{"he","him","his"});
            MainSim sim = new MainSim();
            sim.CurrState = new January(player, sim);
            sim.Year = 1;
            sim.Player = player;

            for (int i = 0; i <= 12; i++)
            {
                sim.CurrState.GoNext();
            }
            
            Assert.AreEqual(2, sim.Year);
        }
    }
}