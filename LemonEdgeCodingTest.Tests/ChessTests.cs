using FluentAssertions;
using LemonEdgeCodingTest.Chess;

namespace LemonEdgeCodingTest.Tests
{
    public class ChessTests
    {
        private readonly ChessBoardSettings _settings;

        public ChessTests()
        {
            _settings = new ChessBoardSettings(8, 8);
        }

        [Theory]
        [InlineData(0, 0, 14)]
        [InlineData(3, 4, 14)]
        [InlineData(7, 7, 14)]
        public void Rook_GetPossibleMoves_ReturnsCorrectMoves(int x, int y, int expectedMoveCount)
        {
            var sut = new Rook();
            var moves = sut.GetPossibleMoves(new Point(x, y), _settings);
            moves.Should().HaveCount(expectedMoveCount);
        }

        [Theory]
        [InlineData(0, 0, 7)]
        [InlineData(3, 4, 13)]
        [InlineData(7, 7, 7)]
        public void Bishop_GetPossibleMoves_ReturnsCorrectMoves(int x, int y, int expectedMoveCount)
        {
            var sut = new Bishop();
            var moves = sut.GetPossibleMoves(new Point(x, y), _settings);
            moves.Should().HaveCount(expectedMoveCount);
        }

        [Theory]
        [InlineData(0, 0, 2)]
        [InlineData(3, 4, 8)]
        [InlineData(7, 7, 2)]
        public void Knight_GetPossibleMoves_ReturnsCorrectMoves(int x, int y, int expectedMoveCount)
        {
            var sut = new Knight();
            var moves = sut.GetPossibleMoves(new Point(x, y), _settings);
            moves.Should().HaveCount(expectedMoveCount);
        }

        [Theory]
        [InlineData(true,0, 0, 0)]
        [InlineData(true,3, 4, 1)]
        [InlineData(true,7, 7, 1)]
        [InlineData(false, 0, 0, 1)]
        [InlineData(false, 3, 4, 1)]
        [InlineData(false, 7, 7, 0)]
        public void Pawn_GetPossibleMoves_ReturnsCorrectMoves(bool whiteToPlay, int x, int y, int expectedMoveCount)
        {
            var sut = new Pawn();
            var settings = new ChessBoardSettings(8, 8, whiteToPlay);
            var moves = sut.GetPossibleMoves(new Point(x, y), settings);
            moves.Should().HaveCount(expectedMoveCount);
        }

        [Theory]
        [InlineData(0, 0, 3)]
        [InlineData(3, 4, 8)]
        [InlineData(7, 7, 3)]
        public void King_GetPossibleMoves_ReturnsCorrectMoves(int x, int y, int expectedMoveCount)
        {
            var sut = new King();
            var moves = sut.GetPossibleMoves(new Point(x, y), _settings);
            moves.Should().HaveCount(expectedMoveCount);
        }

        [Theory]
        [InlineData(0, 0, 21)]
        [InlineData(3, 4, 27)]
        [InlineData(7, 7, 21)]
        public void Queen_GetPossibleMoves_ReturnsCorrectMoves(int x, int y, int expectedMoveCount)
        {
            var sut = new Queen();
            var moves = sut.GetPossibleMoves(new Point(x, y), _settings);
            moves.Should().HaveCount(expectedMoveCount);
        }
    }
}