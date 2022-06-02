﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using TestTaskAkvelon;
using TestTaskAkvelon.Controllers;

namespace TestTaskAkvelon.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Упорядочение
            HomeController controller = new HomeController();

            // Действие
            ViewResult result = controller.Index() as ViewResult;

            // Утверждение
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
