// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueSourceTests.cs" company="">
//   
// </copyright>
// <summary>
//   The value source tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.Tests.Unit.DataSources
{
    using AutoPoco.DataSources;

    using NUnit.Framework;

    /// <summary>
    /// The value source tests.
    /// </summary>
    [TestFixture]
    public class ValueSourceTests
    {
        #region Fields

        /// <summary>
        /// The source.
        /// </summary>
        private ValueSource<int> source;

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The next_ returns value.
        /// </summary>
        [Test]
        public void Next_ReturnsValue()
        {
            Assert.AreEqual(10, this.source.Next(null));
        }

        /// <summary>
        /// The setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.source = new ValueSource<int>(10);
        }

        #endregion
    }
}