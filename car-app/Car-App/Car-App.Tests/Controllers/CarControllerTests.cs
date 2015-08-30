using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car_App;
using Car_App.Controllers;

namespace Car_App.Tests.Controllers
{
   public class CarControllerTests
    {
       [TestMethod]
       public void Index()
       {
           // Arrange
           CarController controller = new CarController();

           // Act
           ViewResult result = controller.Car() as ViewResult;

           // Assert
           Assert.IsNotNull(result);
       }

    }
}
