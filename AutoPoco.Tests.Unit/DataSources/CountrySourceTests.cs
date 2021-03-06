﻿using System.Diagnostics;
using AutoPoco.DataSources;
using NUnit.Framework;

namespace AutoPoco.Tests.Unit.DataSources
{
    [TestFixture]
    public class CountrySourceTests
    {
        [Test]
        public void Next_Returns_A_Country()
        {
            CountrySource source = new CountrySource();
            var value = source.Next(null);
            Assert.That(value, Is.Not.Null.And.Not.Empty);
            Debug.WriteLine(string.Format("Welcome to {0}", value));
        }
    }
}