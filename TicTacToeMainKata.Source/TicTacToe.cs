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
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(TopRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(CenterRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterRight, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer)))
            {
                return currentPlayer;
            }

            SwapPlayers();
            
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(TopRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(CenterRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterRight, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer)))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer)))
            {
                return currentPlayer;
            }
            
            return DRAW;

        }
    }
}
