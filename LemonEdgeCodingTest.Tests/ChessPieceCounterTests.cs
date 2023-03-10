using FluentAssertions;
using LemonEdgeCodingTest.Chess;
using LemonEdgeCodingTest.Keypad;
using LemonEdgeCodingTest.PhoneNumber;

namespace LemonEdgeCodingTest.Tests
{
    public class ChessPieceCounterTests
    {
        [Fact]
        public void ChessPieceCounter_ReturnsCorrectCount()
        {
            var keypad = new StandardTelephoneKeypad();
            var phoneNumberValidator = new PhoneNumberValidator();

            var rookCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Rook()).GetCount();
            rookCount.Should().Be(49326);

            var bishopCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Bishop()).GetCount();
            bishopCount.Should().Be(2341);

            var knightCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Knight()).GetCount();
            knightCount.Should().Be(952);

            var kingCount = new ChessPieceCounter(keypad, phoneNumberValidator, new King()).GetCount();
            kingCount.Should().Be(124908);

            var queenCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Queen()).GetCount();
            queenCount.Should().Be(751503);

            var whitePawnCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn()).GetCount();
            whitePawnCount.Should().Be(0);

            var blackPawnCount = new ChessPieceCounter(keypad, phoneNumberValidator, new Pawn(), false).GetCount();
            blackPawnCount.Should().Be(0);
        }
    }
}
