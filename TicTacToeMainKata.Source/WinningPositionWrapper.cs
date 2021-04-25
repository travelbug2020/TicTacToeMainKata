﻿using System;
using System.Collections.Generic;
using System.Text;
using static TicTacToeMainKata.Source.Position;

namespace TicTacToeMainKata.Source
{  public class WinningPositionWrapper
    {
        public readonly List<Position[]> winningPositions = new List<Position[]>
        {
            new[] {TopLeft, TopMiddle, TopRight},
            new[] {CenterLeft,CenterMiddle,CenterRight},
            new[] {BottomLeft,BottomMiddle,BottomRight},
            new[] {TopLeft,CenterLeft,BottomLeft},
            new[] {TopMiddle,CenterMiddle,BottomMiddle},
            new[] {TopRight,CenterRight,BottomRight},
            new[] {TopRight,CenterMiddle,BottomLeft},
            new[] {TopLeft,CenterMiddle,BottomRight}
        };
    }
}
