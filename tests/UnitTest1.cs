using Microsoft.VisualStudio.TestTools.UnitTesting;
using myWebApp.Controllers;
using System.Web.Mvc;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HomeController_Index_ReturnsView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void HomeController_Privacy_ReturnsView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Privacy() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}