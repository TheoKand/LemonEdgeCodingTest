namespace LemonEdgeCodingTest.Chess
{
    public class Knight : ChessPiece
    {
        public override IEnumerable<Point> GetPossibleMoves(Point fromHere, ChessBoardSettings settings)
        {
            var possibleMoves = new List<Point>();

            //Knight can move 2 left 1 up
            EvaluateAndAddMove(settings, new Point(fromHere.X - 2, fromHere.Y - 1), possibleMoves);
            //Knight can move 1 left 2 up
            EvaluateAndAddMove(settings, new Point(fromHere.X - 1, fromHere.Y - 2), possibleMoves);

            //Knight can move 2 right 1 up
            EvaluateAndAddMove(settings, new Point(fromHere.X + 2, fromHere.Y - 1), possibleMoves);
            //Knight can move 1 right 2 up
            EvaluateAndAddMove(settings, new Point(fromHere.X + 1, fromHere.Y - 2), possibleMoves);

            //Knight can move 2 left 1 down
            EvaluateAndAddMove(settings, new Point(fromHere.X - 2, fromHere.Y + 1), possibleMoves);
            //Knight can move 1 left 2 down 
            EvaluateAndAddMove(settings, new Point(fromHere.X - 1, fromHere.Y + 2), possibleMoves);

            //Knight can move 2 right 1 down
            EvaluateAndAddMove(settings, new Point(fromHere.X + 2, fromHere.Y + 1), possibleMoves);
            //Knight can move 1 right 2 down
            EvaluateAndAddMove(settings, new Point(fromHere.X + 1, fromHere.Y + 2), possibleMoves);

            return possibleMoves.Distinct();
        }
    }
}
