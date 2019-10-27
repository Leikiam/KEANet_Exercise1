using System;
using Xunit;
using KEANet;

namespace KEANetTest
{
    public class Test
    {
        [Fact]
        public void ExcludeInternetConnectionTest()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.IncludeExcludeInternetConnection(true);

            //Assert
            Assert.Equal(200, purchase.Price);
        }

        [Fact]
        public void IncludeInternetConnectionTest()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 200;
            purchase.IncludeExcludeInternetConnection(false);

            //Assert
            Assert.Equal(0, purchase.Price);
        }

        [Fact]
        public void IncrementPhoneLineNumber()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.IncrementPhoneLineNumber();

            //Assert
            Assert.Equal(150, purchase.Price);
        }

        [Fact]
        public void DecrementPhoneLineNumber()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 1000;
            purchase.PhoneLines = 4;
            purchase.DecrementPhoneLineNumber();

            //Assert
            Assert.Equal(850, purchase.Price);
        }

        [Fact]
        public void SelectCellPhone()
        {
            //Arrange
            Purchase purchase = new Purchase();
            string phoneModel = "iPhone 99";

            //Act
            purchase.SelectCellPhone(phoneModel);

            //Assert
            Assert.Equal(6000, purchase.Price);
        }

        [Fact]
        public void UnselectCellPhone()
        {
            //Arrange
            Purchase purchase = new Purchase();
            string phoneModel = "Huawei 99";

            //Act
            purchase.Price = 3500;
            purchase.UnselectCellPhone(phoneModel);

            //Assert
            Assert.Equal(2600, purchase.Price);
        }

        [Fact]
        public void Buy()
        {
            //Arrange
            Purchase purchase = new Purchase();

            //Act
            purchase.Price = 2000;

            //Assert
            Assert.Equal("You have bought items for a total of 2000 DKK", purchase.Buy());
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
    }
}
