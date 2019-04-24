using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyberPunk;
using CyberPunk.Controllers;
using CyberPunk.ViewModels;

namespace CyberPunk.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void DiceTest()
        {
            ModelData datas = new ModelData();

            int result = datas.GetResult(10, 12);

            
        }
        [TestMethod]
        public void UnderFeatureTest()
        {
            ModelData datas = new ModelData();
            int dice;
            int testValue = 9;
            bool ok = datas.UnderFeature(out dice);

            Assert.AreEqual(dice <=testValue, ok);

        }

    }
}
