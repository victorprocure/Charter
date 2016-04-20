//-----------------------------------------------------------------------
// <copyright file="DepartureLocationCanBeSelected.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------

namespace Charter.Tests
{
    using System;
    using Charter.Web.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.BDDfy;

    [TestClass]
    [Story(
        AsA = "As a user",
        IWant = "I want to choose a departure location",
        SoThat = "So that I can choose where I'm departing from")]
    internal class DepartureLocationCanBeSelected
    {
        private City city;
        private User user;

        private void GivenTestCityExists()
        {
            this.city = new City("TestCity");
        }

        private void AndGivenAnAnonymousUserExists()
        {
            this.user = new User();
        }

        private void WhenTheUserSelectsTestCityAsDeparture()
        {
            this.user.ChangeDeparture(this.city);
        }

        private void ThenUsersDepartureCityNameShouldBeTestCity()
        {
            Assert.AreEqual(this.city.Name, this.user.Departure.Name);
        }

        [TestMethod]
        public void TestUserDepartureCity()
        {
            this.BDDfy();
        }
    }
}