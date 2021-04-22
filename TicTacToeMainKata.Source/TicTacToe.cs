using System;
using static TicTacToeMainKata.Source.Player;
using static TicTacToeMainKata.Source.Position;

namespace TicTacToeMainKata.Source
{
    public class TicTacToe
    {
        private Player currentPlayer = X;
        public Player GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public void MarkPosition(Position position)
        { 
            SwapPlayers();
        }

        private void SwapPlayers()
        {
            if (currentPlayer == X)
            {
                currentPlayer = O;
                return;
            }

            currentPlayer = X;
        }

        public Player GetWinner()
        {
            return X;
        }
    }
}
