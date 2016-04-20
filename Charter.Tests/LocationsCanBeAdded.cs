//-----------------------------------------------------------------------
// <copyright file="LocationsCanBeAdded.cs" company="Procure Development">
//     Copyright (c) Procure Development. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------

namespace Charter.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestStack.BDDfy;
    using Web.Models;

    [TestClass]
    [Story(
        AsA = "As an administrator",
        IWant = "I want to be able to add locations",
        SoThat = "So that they can be used as arrivals or departures")]
    internal class LocationsCanBeAdded
    {
        private User user;

        public void GivenThatWeAreAUserNamedTestUser()
        {
            this.user = new User("Test User");
        }

        public void AndGivenThatWeAreAnAdministrator()
        {
            this.user.ChangeRole(UserRoles.Administrator);

            Assert.AreEqual(UserRoles.Administrator, this.user.Role);
        }

        public void ThenWeShouldBeAbleToAddALocation()
        {
        }
    }
}