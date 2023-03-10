namespace LemonEdgeCodingTest.Chess
{
    public class King : ChessPiece
    {
        public override IEnumerable<Point> GetPossibleMoves(Point fromHere, ChessBoardSettings settings)
        {
            var possibleMoves = new List<Point>();

            //King can move one square in any direction
            EvaluateAndAddMove(settings, new Point(fromHere.X - 1, fromHere.Y - 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X, fromHere.Y - 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X + 1, fromHere.Y - 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X + 1, fromHere.Y), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X + 1, fromHere.Y + 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X, fromHere.Y + 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X - 1, fromHere.Y + 1), possibleMoves);
            EvaluateAndAddMove(settings, new Point(fromHere.X - 1, fromHere.Y), possibleMoves);

            return possibleMoves.Distinct();
        }
    }
}
