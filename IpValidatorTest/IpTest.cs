using IpAddressValidator;
namespace IpValidatorTest
{
    public class IpTest
    {
        [Theory]
        [InlineData("192.168.0.1", true)]
        [InlineData("10.0.0.0", true)]
        [InlineData("256.0.0.1", false)]
        [InlineData("123.456.789.0", false)]
        [InlineData("192.168.0", false)]
        [InlineData("192.168.0.1.2", false)]
        [InlineData("01.02.03.04", false)]
        public void ValidateIPAddress_ValidAndInvalidIPs_ReturnsCorrectResult(string ipAddress, bool expectedResult)
        {
            // Arrange
            IpChecker validator = new IpChecker();

            // Act
            bool isValid = validator.ValidateIPAddress(ipAddress);

            // Assert
            Assert.Equal(expectedResult, isValid);
        }
    }
}