using System.Collections.Generic;
using System.Linq;
using static TicTacToeMainKata.Source.Player;

namespace TicTacToeMainKata.Source
{
    public class Board
    {
        private readonly Dictionary<Position, Player> _board = new Dictionary<Position, Player>();
        private readonly WinningPositions _listOfWinningMoves = new WinningPositions();

        private bool IsAWinningLine(Position winningPosition1, Position winningPosition2, Position winningPosition3)
        {
            return _board.ContainsKey(winningPosition1) && _board.ContainsKey(winningPosition2) &&
                   _board.ContainsKey(winningPosition3) && _board[winningPosition1] == _board[winningPosition2] &&
                   _board[winningPosition2] == _board[winningPosition3];
        }

        public Player GetWinner()
        {
            var winningLine = _listOfWinningMoves.Positions.FirstOrDefault(winningMoves =>
                IsAWinningLine(winningMoves[0], winningMoves[1], winningMoves[2]));
            if (winningLine == null)
            {
                return NONE;
            }
            return _board[winningLine[0]];
        }

        public void MarkAt(Position position, Player currentPlayer)
        {
            _board.Add(position, currentPlayer);
        }
    }
}