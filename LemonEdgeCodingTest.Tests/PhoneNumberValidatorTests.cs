using FluentAssertions;
using LemonEdgeCodingTest.PhoneNumber;

namespace LemonEdgeCodingTest.Tests
{
    public class PhoneNumberValidatorTests
    {
        [Theory]
        [InlineData("",false)]
        [InlineData("555555", false)]
        [InlineData("5555555", true)]
        [InlineData("55*5555", false)]
        [InlineData("55#5555", false)]
        [InlineData("1555555", false)]
        [InlineData("0555555", false)]
        public void IsValid_ReturnsCorrectValue(string phoneNumber, bool expectedResult)
        {
            var sut = new PhoneNumberValidator();
            var isValid = sut.IsValid(phoneNumber);
            isValid.Should().Be(expectedResult);
        }
    }
}
