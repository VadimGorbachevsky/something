﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Library.Tests
{
    [TestFixture]
    public class TennisTests
    {
        //************
        //PLAYER TESTS
        //************

        [Test]
        public void CreatePlayerName()
        {
            Player player = new Player("Name");
            Assert.IsTrue(player.Name() == "Name");
        }
        [Test]
        public void CreatePlayerScore()
        {
            Player player = new Player("Name");
            Assert.IsTrue(player.Score() == 0);
        }

        [Test]
        public void UpPlayerScoreOne()
        {
            Player player = new Player("Name");
            player.UpScore(1);
            Assert.IsTrue(player.Score() == 1);
        }
        [Test]
        public void UpPlayerScoreMany()
        {
            Player player = new Player("Name");
            player.UpScore(12);
            Assert.IsTrue(player.Score() == 12);
        }

        [Test]
        public void UpPlayerScoreDaun()
        {
            Player player = new Player("Name");
            player.UpScore(12);
            player.UpScore(-1);
            Assert.IsTrue(player.Score() == 12);
        }
        [Test]
        public void UpPlayerScoreZero()
        {
            Player player = new Player("Name");
            player.UpScore(12);
            player.UpScore(0);
            Assert.IsTrue(player.Score() == 12);
        }
        [Test]
        public void DawnPlayerScoreOne()
        {
            Player player = new Player("Name");
            player.UpScore(2);
            player.DownScore(1);
            Assert.IsTrue(player.Score() == 1);
        }
        [Test]
        public void DawnPlayerScoreMany()
        {
            Player player = new Player("Name");
            player.UpScore(5);
            player.DownScore(2);
            Assert.IsTrue(player.Score() == 3);
        }
        [Test]
        public void DawnPlayerScoreZero()
        {
            Player player = new Player("Name");
            player.UpScore(5);
            player.DownScore(0);
            Assert.IsTrue(player.Score() == 5);
        }
        [Test]
        public void DawnPlayerScoreToZero()
        {
            Player player = new Player("Name");
            player.UpScore(5);
            player.DownScore(5);
            Assert.IsTrue(player.Score() == 0);
        }
        [Test]
        public void DawnPlayerScoreToZeroOverflow()
        {
            Player player = new Player("Name");
            player.UpScore(5);
            player.DownScore(7);
            Assert.IsTrue(player.Score() == 0);
        }

        [Test]
        public void DownPlayerScoreUp()
        {
            Player player = new Player("Name");
            player.UpScore(12);
            player.DownScore(-1);
            Assert.IsTrue(player.Score() == 12);
        }

        //************
        //GAME-LOGIC TESTS
        //************
        /*
        [Test]
        public void PlayersCorrectly()
        {
            TennisGame game = new TennisGame("Name_1", "Name_2");
            Assert.IsTrue(game.Player_1().Name() == "Name_1");
            Assert.IsTrue(game.Player_2().Name() == "Name_2");
        }
        public void PlayersDifferent()
        {
            TennisGame game = new TennisGame("Eman", "Eman");
            Assert.IsTrue(game.Player_1().Name() == "Eman_1");
            Assert.IsTrue(game.Player_2().Name() == "Eman_2");
        }
        [Test]
        public void BallOnFirst()
        {
            TennisGame game = new TennisGame();
            Assert.IsTrue(game.Ball() == game.Player_1());
        }

        [Test]
        public void StartAdvantage()
        {
            TennisGame game = new TennisGame();
            Assert.IsTrue(game.Advantage() == "Nothng");
            //We use player name or nothing to avoid creation third player
        }
        [Test]
        public void SetAdvantage()
        {
            TennisGame game = new TennisGame();
            game.SetAdvantage(1);
            Assert.IsTrue(game.Advantage() == game.Player_1().Name());
        }

        [Test]
        public void StartLeftSide()
        {
            TennisGame game = new TennisGame();
            Assert.IsTrue(game.LeftSide() == game.Player_1());            
        }
        [Test]
        public void StartRightSide()
        {
            TennisGame game = new TennisGame();
            Assert.IsTrue(game.RightSide() == game.Player_2());            
        }
        [Test]
        public void ChangeSides()
        {
            TennisGame game = new TennisGame();
            game.ChangeSides(1);
            Assert.IsTrue( (game.LeftSide() == game.Player_2()) && (game.RightSide() == game.Player_1()) ) ;            
        }
        */

    }
}
