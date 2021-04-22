using System.Collections.Generic;

namespace TicTacToeMainKata.Source
{
    public class Board
    {
        public Dictionary<Position,Player> playerMoves = new Dictionary<Position, Player>();
    }
}