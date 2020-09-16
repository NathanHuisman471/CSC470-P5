using System;
using E3_Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFakeEmployeeRepository
{
    [TestClass]
    public class SetAuthentication
    {
        [TestMethod]
        public void GetSetAuthenticationIsCorrect()
        {
            // Arrange
            const string UserName = davebish;
            const bool EXPECTED_AUTHENTICATION = false;
            FakeAppUserRepository appUserRepository = new FakeAppUserRepository();
            
            // Act
            decimal ActualAuthentication = appUserRepository.SetAuthentication(UserName);

            // Assert
            Assert.AreEqual(EXPECTED_AUTHENTICATION, ActualAuthentication);
        }
    }
}
