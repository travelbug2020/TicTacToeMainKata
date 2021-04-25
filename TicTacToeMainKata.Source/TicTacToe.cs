using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading;
using static TicTacToeMainKata.Source.Player;
using static TicTacToeMainKata.Source.Position;
using System.Linq;

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
            var listOfWinningMoves = new WinningPositionWrapper();

            Player actualValue;
            if (board.playerMoves.TryGetValue(TopLeft, out actualValue) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(TopMiddle, out actualValue) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(TopRight, out actualValue) && actualValue == GetCurrentPlayer())) 
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(CenterRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }


            SwapPlayers();
            
            if (board.playerMoves.TryGetValue(TopLeft, out actualValue) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(TopMiddle, out actualValue) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(TopRight, out actualValue) && actualValue == GetCurrentPlayer())) 
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(CenterRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopLeft, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(TopRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(CenterMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }
            if (board.playerMoves.TryGetValue(BottomRight, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                (board.playerMoves.TryGetValue(BottomMiddle, out currentPlayer) && actualValue == GetCurrentPlayer() &&
                 board.playerMoves.TryGetValue(BottomLeft, out currentPlayer) && actualValue == GetCurrentPlayer()))
            {
                return currentPlayer;
            }

            return DRAW;

        }
    }
}
