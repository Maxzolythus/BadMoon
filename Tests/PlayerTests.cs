

using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using WerewolfSim2k17.Main;
using WerewolfSim2k17.Player;

namespace WerewolfSimCSharp.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        /// <summary>
        /// Tests the regular exprestion used to sort pronouns
        /// </summary>
        [Test]
        public void pronounTest()
        {
            string pronounStr = "he,him,his";
            const string pronounPat = "(\\s*\\w+,\\s*){2}\\w+";
            Regex pronounRgx = new Regex(pronounPat);
            
            Assert.IsTrue(pronounRgx.IsMatch(pronounStr));

            pronounStr = "he/him/his";
            
            Assert.IsFalse(pronounRgx.IsMatch(pronounStr));
            
            pronounStr = "h3,h1m,his";
            
            Assert.IsTrue(pronounRgx.IsMatch(pronounStr));
            
            pronounStr = "he, him, his";
            
            Assert.IsTrue(pronounRgx.IsMatch(pronounStr));

        }
        
        /// <summary>
        /// Tests if skills upgrade acordingly
        /// </summary>
        [Test]
        public void skillUpTests()
        {
            Player player = new Player("AJ", new []{"they","them","their"});
            player.statsExp["Str"] = 3;
            player.statUpgrade();
            
            Assert.IsTrue(player.stats["Str"]==6);
        }
        
        /// <summary>
        /// Tests if level increases acordingly
        /// </summary>
        [Test]
        public void lvlUpTests()
        {
            Player player = new Player("AJ", new []{"they","them","their"});
            player.statsExp["lvl"] = 12;
            player.levelUp();
            
            Assert.IsTrue(player.Lvl==2);
            Assert.IsTrue(player.statsExp["lvl"]==0);
        }
    }
}