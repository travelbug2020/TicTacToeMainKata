using System;
using static TicTacToeMainKata.Source.Player;
using static TicTacToeMainKata.Source.Position;

namespace TicTacToeMainKata.Source
{
    public class TicTacToe
    {
        Board board = new Board();
        private Player currentPlayer = X;
        public Player GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public void MarkPosition(Position position)
        {
            board.playerMoves.Add(position, GetCurrentPlayer());
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
