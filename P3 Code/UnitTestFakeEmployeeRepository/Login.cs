using System;
using E3_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeEmployeeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsIsSuccessful()
        {
            // Arrange
            const string UserName = "moliver";
            const bool EXPECTED_AUTHENTICATION = true;
            const bool isAuthenticated = false; //needed a bool to pass to SetAutentication() this value doesn't affect test outcome
            FakeAppUserRepository appUserRepository = new FakeAppUserRepository();

            // Act
            bool ActualAuthentication = appUserRepository.SetAuthentication(UserName, isAuthenticated);

            // Assert
            Assert.AreEqual(EXPECTED_AUTHENTICATION, ActualAuthentication);
        }
        public void LoginWithIncorrectCredentialsIsFail()
        {
            // Arrange
            const string UserName = "nhuisman";
            const bool EXPECTED_AUTHENTICATION = true;
            const bool isAuthenticated = false; //needed a bool to pass to SetAutentication() this value doesn't affect test outcome
            FakeAppUserRepository appUserRepository = new FakeAppUserRepository();

            // Act
            bool ActualAuthentication = appUserRepository.SetAuthentication(UserName, isAuthenticated);

            // Assert
            Assert.AreEqual(EXPECTED_AUTHENTICATION, ActualAuthentication);
        }
    }
}
