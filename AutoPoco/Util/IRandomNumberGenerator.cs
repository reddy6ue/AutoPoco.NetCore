// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRandomNumberGenerator.cs" company="">
//   
// </copyright>
// <summary>
//   The RandomNumberGenerator interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace AutoPoco.Util
{
    /// <summary>
    ///     The RandomNumberGenerator interface.
    /// </summary>
    public interface IRandomNumberGenerator
    {
        #region Public Methods and Operators

        /// <summary>
        /// Gets the next random number.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Next();

        /// <summary>
        /// Gets the next random number between zero and the given max value.
        /// </summary>
        /// <param name="maxValue">
        /// The max value.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Next(int maxValue);

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
        int Next(int minValue, int maxValue);

        /// <summary>
        /// The next double.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        double NextDouble();

        #endregion

        /// <summary>
        /// Fills the buffer with a collection of random bytes.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        void NextBytes(byte[] buffer);
    }
}