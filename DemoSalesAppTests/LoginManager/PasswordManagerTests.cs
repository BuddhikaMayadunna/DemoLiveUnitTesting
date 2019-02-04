using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DemoSalesApp.LoginManager.PasswordManager;

namespace DemoSalesApp.LoginManager.Tests
{
    [TestClass()]
    public class PasswordManagerTests
    {

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordLengthLessThan1_TooShort()
        {
            //Arrange
            var password = "";
            var expected = PasswordStrengthScore.TooShort;
            //Act
            PasswordStrengthScore actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordLengthLessThan4_VeryWeak()
        {
            //Arrange
            var password = "see";
            var expected = PasswordStrengthScore.VeryWeak;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordLengthGraterThan8_VeryWeak()
        {
            //Arrange
            var password = "dfsdsdfff";
            var expected = PasswordStrengthScore.VeryWeak;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordLengthGraterThan12_VeryWeak()
        {
            //Arrange
            var password = "dfsdsdfdsbvfb";
            var expected = PasswordStrengthScore.Weak;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordIncludesNumberCheck_Medium()
        {
            //Arrange
            var password = "felloworldfasword1";
            var expected = PasswordStrengthScore.Medium;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordCharacterCaseCheck_Strong()
        {
            //Arrange
            var password = "HelloWorldPasword1";
            var expected = PasswordStrengthScore.Strong;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvaluatePasswordStrngth_PasswordSpecialCharacterCheck_VeryStrong()
        {
            //Arrange
            var password = "HelloWorldPasword1@";
            var expected = PasswordStrengthScore.VeryStrong;
            //Act
            var actual = EvaluatePasswordStrngth(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}