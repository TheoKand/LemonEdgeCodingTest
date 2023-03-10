using FluentAssertions;
using LemonEdgeCodingTest.Keypad;

namespace LemonEdgeCodingTest.Tests
{
    public class StandardPhoneKeypadTests
    {
        [Fact]
        public void StandardPhoneKeypad_IsStandardPhoneKeypad()
        {
            var sut = new StandardTelephoneKeypad();
            var expectedButtons = new string[]
            {
                "123",
                "456",
                "789",
                "*0#",
            };

            sut.Width.Should().Be(3);
            sut.Height.Should().Be(4);
            for (var x = 0; x < expectedButtons.Length - 1; x++)
            {
                for (var y = 0; y < expectedButtons[x].Length - 1; y++)
                {
                    sut.GetButton(x, y).Should().Be(expectedButtons[y][x]);
                }
            }
        }
    }
}
