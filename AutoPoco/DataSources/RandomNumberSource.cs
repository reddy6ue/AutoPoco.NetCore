// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RandomStringSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System.Text;

    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The random string source.
    /// </summary>
    public class RandomNumberSource : DatasourceBase<int>
    {
        #region Fields

        /// <summary>
        /// The max.
        /// </summary>
        private readonly int max;

        /// <summary>
        /// The min.
        /// </summary>
        private readonly int min;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RandomStringSource"/> class.
        /// </summary>
        /// <param name="min">
        /// The min.
        /// </param>
        /// <param name="max">
        /// The max.
        /// </param>
        public RandomNumberSource(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public RandomNumberSource()
            : this(0, 10000)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The next.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>. 
        /// </returns>
        public override int Next(IGenerationContext context)
        {
            return RandomNumberGenerator.Current.Next(this.min, this.max + 1);
        }

        #endregion
    }
}