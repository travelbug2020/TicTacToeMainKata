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

        [Test]
        public void PlayerXWins_WhenLeftHorizontal_IsAllX()
        {
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(BottomMiddle);
            ticTacToe.MarkPosition(CenterLeft);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(BottomLeft);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenCenterHorizontal_IsAllX()
        {
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(TopRight);
            ticTacToe.MarkPosition(BottomMiddle);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenRightHorizontal_IsAllX()
        {
            ticTacToe.MarkPosition(TopRight);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterRight);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(BottomRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenDiagonalFromTopRight_IsAllX()
        {
            ticTacToe.MarkPosition(TopRight);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(BottomLeft);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerXWins_WhenDiagonalFromTopLeft_IsAllX()
        {
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(CenterLeft);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(TopMiddle);
            ticTacToe.MarkPosition(BottomRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(X, player);
        }

        [Test]
        public void PlayerOWins_WhenDiagonalFromTopLeft_IsAllO()
        {
            ticTacToe.MarkPosition(CenterRight);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(TopRight);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(BottomLeft);
            ticTacToe.MarkPosition(BottomRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(O, player);
        }

        [TestCase(new[] { TopMiddle, TopLeft, CenterMiddle, TopRight, CenterRight, CenterLeft, BottomLeft, BottomMiddle, BottomRight }, NONE)]
        public void Draw_WhenAllSquaresAreFilled_ButNoWinner(Position[] positions, Player winner)
        {
            PlayMovesAt(positions);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(winner, player);
        }

        private void PlayMovesAt(Position[] positions)
        {
            foreach (var position in positions)
            {
                ticTacToe.MarkPosition(position);
            }
        }

        [Test]
        public void PlayerCannot_playOnMarkedPosition_WillGiveThemAnotherChance()
        {
            ticTacToe.MarkPosition(CenterRight);
            ticTacToe.MarkPosition(CenterRight);
            ticTacToe.MarkPosition(TopLeft);
            ticTacToe.MarkPosition(TopRight);
            ticTacToe.MarkPosition(CenterMiddle);
            ticTacToe.MarkPosition(BottomLeft);
            ticTacToe.MarkPosition(BottomRight);

            var player = ticTacToe.GetWinner();

            Assert.AreEqual(O, player);
        }
    }
}