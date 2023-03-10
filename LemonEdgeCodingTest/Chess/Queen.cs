namespace LemonEdgeCodingTest.Chess
{
    public class Queen : ChessPiece
    {
        public override IEnumerable<Point> GetPossibleMoves(Point fromHere, ChessBoardSettings settings)
        {
            var possibleMoves = new List<Point>();

            //Queen can move as a bishop
            possibleMoves.AddRange((new Bishop()).GetPossibleMoves(fromHere, settings));

            //Queen can move as a rook
            possibleMoves.AddRange((new Rook()).GetPossibleMoves(fromHere, settings));

            return possibleMoves.Distinct();
        }
    }
}
