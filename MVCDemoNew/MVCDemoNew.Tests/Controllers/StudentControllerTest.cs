using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCDemoNew.Controllers;
using System.Web.Mvc;

namespace MVCDemoNew.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {
        [TestMethod]
        public void Save()
        { 
            // Arrange
            StudentController controller = new StudentController(null);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
