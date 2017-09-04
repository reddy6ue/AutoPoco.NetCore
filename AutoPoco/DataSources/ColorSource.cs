// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ColorSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System.Drawing;

    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The color source.
    /// </summary>
    public class ColorSource : DatasourceBase<Color>
    {
        #region Fields

        /// <summary>
        /// The m max.
        /// </summary>
        private readonly int max;

        /// <summary>
        /// The m min.
        /// </summary>
        private readonly int min;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorSource"/> class.
        /// </summary>
        public ColorSource()
        {
            this.min = 0;
            this.max = 255;
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
        /// The <see cref="Color"/>.
        /// </returns>
        public override Color Next(IGenerationContext context)
        {
            return Color.FromArgb(
                RandomNumberGenerator.Current.Next(this.min, this.max), 
                RandomNumberGenerator.Current.Next(this.min, this.max), 
                RandomNumberGenerator.Current.Next(this.min, this.max));
        }

        #endregion
    }
}