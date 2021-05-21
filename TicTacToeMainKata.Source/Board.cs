using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeMainKata.Source
{
    public class Board
    {
        private readonly Dictionary<Position, Player> _board = new Dictionary<Position, Player>();
        private readonly WinningPositions _listOfWinningMoves = new WinningPositions();

        private bool IsLineTaken(Position winningPosition1, Position winningPosition2, Position winningPosition3)
        {
            return _board.ContainsKey(winningPosition1) && _board.ContainsKey(winningPosition2) &&
                   _board.ContainsKey(winningPosition3) && _board[winningPosition1] == _board[winningPosition2] &&
                   _board[winningPosition2] == _board[winningPosition3];
        }

        public Player GetWinner()
        {
            foreach (var winningMoves in _listOfWinningMoves.Positions.Where(winningMoves => IsLineTaken(winningMoves[0], winningMoves[1], winningMoves[2])))
            {
                return _board[winningMoves[0]];
            }

            return Player.NONE;
        }

        public void MarkAt(Position position, Player currentPlayer)
        {
            
            this._board.Add(position, currentPlayer);
            
        }
    }
}