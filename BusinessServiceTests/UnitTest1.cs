using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessService;
using Domain.Models;

namespace BusinessServiceTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FilterShows_Always_ReturnAnArrayOfShows()
        {
            //Arrange
            var target = new FilterService();

            //Action

            var actual = target.FilterShows(new Request { payload = new[] { new Payload { country = "UK" } } });

            //Assert

            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual,typeof(Show[]));
        }
    }
}
