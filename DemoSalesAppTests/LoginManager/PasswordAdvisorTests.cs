using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DemoSalesApp.LoginManager.PasswordAdvisor;

namespace DemoSalesApp.LoginManager.Tests
{
    [TestClass()]
    public class PasswordAdvisorTests
    {
        [TestMethod]
        public void CheckPasswordStrngth_PasswordLengthLessThan1_TooShort()
        {
            //Arrange
            var password = "";
            var expected = PasswordScore.TooShort;
            //Act
            PasswordScore actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPasswordStrngth_PasswordLengthLessThan4_VeryWeak()
        {
            //Arrange
            var password = "see";
            var expected = PasswordScore.VeryWeak;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPasswordStrngth_PasswordLengthGraterThan8_VeryWeak()
        {
            //Arrange
            var password = "dfsdsdfff";
            var expected = PasswordScore.VeryWeak;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPasswordStrngth_PasswordLengthGraterThan12_VeryWeak()
        {
            //Arrange
            var password = "dfsdsdfdsbvfb";
            var expected = PasswordScore.Weak;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPasswordStrngth_PasswordIncludesNumberCheck_Medium()
        {
            //Arrange
            var password = "felloworldfasword1";
            var expected = PasswordScore.Medium;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPasswordStrngth_PasswordCharacterCaseCheck_Strong()
        {
            //Arrange
            var password = "HelloWorldPasword1";
            var expected = PasswordScore.Strong;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckPasswordStrngth_PasswordSpecialCharacterCheck_VeryStrong()
        {
            //Arrange
            var password = "HelloWorldPasword1@";
            var expected = PasswordScore.VeryStrong;
            //Act
            var actual = PasswordAdvisor.CheckPasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}