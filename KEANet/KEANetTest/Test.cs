using System;
using Xunit;
using KEANet;

namespace KEANetTest
{
    public class Test
    {
        [Theory]
        [InlineData(false, 200)]
        [InlineData(true, 600)]
        public void IncludeExcludeInternetConnectionTest(bool input, int expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 400;
            purchase.IncludeExcludeInternetConnection(input);

            //Assert
            Assert.Equal(expected, purchase.Price);
        }

        [Theory]
        [InlineData(1, 2150)]
        [InlineData(3, 2450)]
        [InlineData(4, 2600)]
        [InlineData(10, 2600)]
        public void IncrementPhoneLineNumber(int numberOfIncrements, int expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 2000;
            purchase.PhoneLines = 4;

            for (int i = 0; i < numberOfIncrements; i++)
            {
                purchase.IncrementPhoneLineNumber();
            }

            //Assert
            Assert.Equal(expected, purchase.Price);
        }

        [Theory]
        [InlineData(0, 2000)]
        [InlineData(1, 1850)]
        [InlineData(4, 1400)]
        [InlineData(5, 1400)]
        [InlineData(10, 1400)] //Boundary Testing -- We provide the test with 0 and one loops 
        public void DecrementPhoneLineNumber(int numberOfDecrements, int expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 2000;
            purchase.PhoneLines = 4;

            for (int i = 0; i < numberOfDecrements; i++)
            {
                purchase.DecrementPhoneLineNumber();
            }

            //Assert
            Assert.Equal(expected, purchase.Price);
        }

        [Theory]
        [InlineData("iPhone 99", 6000)]
        [InlineData("Sony Xperia 99", 900)]
        [InlineData("Samsung Galaxy 99", 1000)]
        [InlineData("Motorola G99", 800)]
        [InlineData("Huawei 99", 900)]
        public void SelectCellPhone(string phoneModel, int expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.SelectCellPhone(phoneModel);

            //Assert
            Assert.Equal(expected, purchase.Price);
        }

        [Theory]
        [InlineData("iPhone 99", 4000)]
        [InlineData("Sony Xperia 99", 9100)]
        [InlineData("Samsung Galaxy 99", 9000)]
        [InlineData("Motorola G99", 9200)]
        [InlineData("Huawei 99", 9100)]
        public void UnselectCellPhone(string phoneModel, int expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 10000;
            purchase.UnselectCellPhone(phoneModel);

            //Assert
            Assert.Equal(expected, purchase.Price);
        }

        [Theory]
        [InlineData(1, "You have bought items for a total of 1 DKK")]
        [InlineData(0, "You have bought items for a total of 0 DKK")]
        [InlineData(-1, "You have bought items for a total of 0 DKK")]
        [InlineData(int.MinValue, "You have bought items for a total of 0 DKK")]
        [InlineData(int.MaxValue, "You have bought items for a total of 2147483647 DKK")]
        public void Buy(int input, string expected)
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = input;

            //Assert
            Assert.Equal(expected, purchase.Buy());
        }

        [Fact]
        public void Reset()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 2000;
            purchase.PhoneLines = 6;
            purchase.Reset();

            //Assert
            Assert.Equal(0, purchase.PhoneLines);
            Assert.Equal(0, purchase.Price);
        }

        [Fact]
        public void Reset2()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 2000;
            purchase.PhoneLines = 6;
            purchase.Reset();

            //Assert
            Assert.Equal(0, purchase.PhoneLines);
            Assert.Equal(1, purchase.Price);
        }
    }
}
