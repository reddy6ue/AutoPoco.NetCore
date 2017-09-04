// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RandomNumberGenerator.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.Util
{
    using System;

    /// <summary>
    ///     The random number generator.
    /// </summary>
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        #region Static Fields

        /// <summary>
        /// The current.
        /// </summary>
        private static IRandomNumberGenerator current;

        #endregion

        #region Fields

        /// <summary>
        ///     The source for the random number generation.
        /// </summary>
        private readonly Random random = new Random();

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the current.
        /// </summary>
        public static IRandomNumberGenerator Current
        {
            get
            {
                return current ?? (current = new RandomNumberGenerator());
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Gets the next random number.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Next()
        {
            return this.random.Next();
        }

        /// <summary>
        /// Gets the next random number between zero and the given max value.
        /// </summary>
        /// <param name="maxValue">
        /// The max value.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Next(int maxValue)
        {
            return this.random.Next(maxValue);
        }

        /// <summary>
        /// Gets the next random number between the min value and the given max value.
        /// </summary>
        /// <param name="minValue">
        /// The min value.
        /// </param>
        /// <param name="maxValue">
        /// The max value.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Next(int minValue, int maxValue)
        {
            return this.random.Next(minValue, maxValue);
        }

        /// <summary>
        ///     The next double.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public double NextDouble()
        {
            return this.random.NextDouble();
        }

        /// <summary>
        /// Fills the buffer with a collection of random bytes.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        public void NextBytes(byte[] buffer)
        {
            this.random.NextBytes(buffer);
        }

        #endregion
    }
}