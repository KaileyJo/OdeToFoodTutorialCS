using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Tests.TestDb;
using OdeToFood.Controllers;
using OdeToFood.Models;

namespace OdeToFood.Tests.Controllers
{
    [TestClass]
    public class RestaurantControllerTests
    {
        [TestMethod]
        public void CreateSavesRestaurantWhenValid()
        {
            var db = new TestOdeToFoodDb();
            var controller = new RestaurantController(db);

            controller.Create(new Restaurant());

            Assert.AreEqual(1, db.Added.Count);
            Assert.AreEqual(true, db.Saved);
        }

        [TestMethod]
        public void CreateDoesNotSaveRestaurantWhenInvalid()
        {
            var db = new TestOdeToFoodDb();
            var controller = new RestaurantController(db);

            controller.ModelState.AddModelError("", "Invalid");
            controller.Create(new Restaurant());

            Assert.AreEqual(0, db.Added.Count);
        }
    }
}
