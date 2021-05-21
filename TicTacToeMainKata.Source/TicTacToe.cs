using System;
using static TicTacToeMainKata.Source.Player;

namespace TicTacToeMainKata.Source
{
    public class TicTacToe
    {
        readonly Board _board = new Board();
        private Player _currentPlayer = X;

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public void MarkPosition(Position position)
        {
            try
            {
                _board.MarkAt(position, GetCurrentPlayer());

            }
            catch (ArgumentException)
            {
                return;
            }
            
            SwapPlayers();
        }

        private void SwapPlayers()
        {
            if (_currentPlayer == X)
            {
                _currentPlayer = O;
                return;
            }

            _currentPlayer = X;
        }

        public Player GetWinner()
        {
            return _board.GetWinner();
        }
    }
}
