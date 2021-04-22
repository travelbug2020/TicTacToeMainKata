using NUnit.Framework;
using TicTacToeMainKata.Source;
using static TicTacToeMainKata.Source.Player;
using static TicTacToeMainKata.Source.Position;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeMain.Test
{
    public class TicTacToeShould
    {
        private TicTacToe ticTacToe;
        [SetUp]
        public void Setup()
        {
            ticTacToe = new TicTacToe();
        }

        [Test]
        public void MakeX_FirstPlayer()
        {
            var player = ticTacToe.GetCurrentPlayer();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void MakeO_SecondPlayer()
        {
            ticTacToe.MarkPosition(CenterLeft);

            var player = ticTacToe.GetCurrentPlayer();

            Assert.AreEqual(O, player);
        }

        [Test]
        public void MakeSure_PlayerAlternates()
        {
            ticTacToe.MarkPosition(CenterLeft);
            ticTacToe.MarkPosition(CenterMiddle);

            var player = ticTacToe.GetCurrentPlayer();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenTopRow_IsAllX()
        {
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterLeft);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(TopRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenMiddleRow_IsAllX()
        {
            ticTacToe.MarkPosition(CenterLeft);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(CenterRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenBottomRow_IsAllX()
        {
            ticTacToe.MarkPosition(BottomLeft);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(BottomMiddle);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(BottomRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        
    }
}