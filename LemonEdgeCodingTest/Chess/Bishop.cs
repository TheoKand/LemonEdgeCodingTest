namespace LemonEdgeCodingTest.Chess
{
    public class Bishop : ChessPiece
    {
        public override IEnumerable<Point> GetPossibleMoves(Point fromHere, ChessBoardSettings settings)
        {
            var possibleMoves = new List<Point>();

            //Bishop can move diagonally to the top left
            var x = fromHere.X;
            var y = fromHere.Y;
            while (true)
            {
                x--;
                y--;
                if (IsValidPoint(settings, x, y))
                {
                    possibleMoves.Add(new Point(x, y));
                }
                else
                {
                    break;
                }
            }

            //Bishop can move diagonally to the top right
            x = fromHere.X;
            y = fromHere.Y;
            while (true)
            {
                x++;
                y--;
                if (IsValidPoint(settings, x, y))
                {
                    possibleMoves.Add(new Point(x, y));
                }
                else
                {
                    break;
                }
            }

            //Bishop can move diagonally to the bottom left
            x = fromHere.X;
            y = fromHere.Y;
            while (true)
            {
                x--;
                y++;
                if (IsValidPoint(settings, x, y))
                {
                    possibleMoves.Add(new Point(x, y));
                }
                else
                {
                    break;
                }
            }

            //Bishop can move diagonally to the bottom right
            x = fromHere.X;
            y = fromHere.Y;
            while (true)
            {
                x++;
                y++;
                if (IsValidPoint(settings, x, y))
                {
                    possibleMoves.Add(new Point(x, y));
                }
                else
                {
                    break;
                }
            }


            return possibleMoves.Distinct();
        }
    }
}
