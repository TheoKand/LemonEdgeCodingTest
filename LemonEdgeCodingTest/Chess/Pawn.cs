namespace LemonEdgeCodingTest.Chess
{
    public class Pawn : ChessPiece
    {
        public override IEnumerable<Point> GetPossibleMoves(Point fromHere, ChessBoardSettings settings)
        {
            var possibleMoves = new List<Point>();

            if (settings.WhitePlayerToPlay!.Value)
            {
                //White pawn can move up one square at a time
                if (fromHere.Y > 0) possibleMoves.Add(fromHere with { Y = fromHere.Y - 1 });
            }
            else
            {
                //Black pawn can move down one square at a time
                if (fromHere.Y < settings.Height - 1) possibleMoves.Add(fromHere with { Y = fromHere.Y + 1 });
            }

            return possibleMoves.Distinct();
        }
    }
}
