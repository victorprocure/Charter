//-----------------------------------------------------------------------
// <copyright file="ArrivalLocationCanBeSelected.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------

namespace Charter.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.BDDfy;
    using Web.Models;

    /// <summary>
    ///
    /// </summary>
    [TestClass]
    [Story(
        AsA = "As a user",
        IWant = "I want to choose an arrival location",
        SoThat = "So that I can choose where I'm travelling to")]
    internal class ArrivalLocationCanBeSelected
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

        private void WhenTheUserSelectsTestCityAsTheirArrival()
        {
            this.user.ChangeArrival(this.city);
        }

        private void ThenUsersDepartureCityNameShouldBeTestCity()
        {
            Assert.AreEqual(this.city.Name, this.user.Arrival.Name);
        }

        [TestMethod]
        public void TestUserArrivalLocation()
        {
            this.BDDfy();
        }
    }
}