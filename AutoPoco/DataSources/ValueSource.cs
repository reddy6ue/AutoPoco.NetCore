// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueSource.cs" company="">
//   
// </copyright>
// <summary>
//   The value source.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;

    /// <summary>
    /// The value source.
    /// </summary>
    /// <typeparam name="T">
    /// </typeparam>
    public class ValueSource<T> : IDatasource<T>
    {
        private readonly T value;

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueSource{T}"/> class.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        public ValueSource(T value)
        {
            this.value = value;
        }

        #endregion

        public object Next(IGenerationContext context)
        {
            return this.value;
        }
    }
}