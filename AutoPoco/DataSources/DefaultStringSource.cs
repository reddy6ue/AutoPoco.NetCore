// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultStringSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;

    /// <summary>
    /// The default string source.
    /// </summary>
    public class DefaultStringSource : DatasourceBase<string>
    {
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
        public override string Next(IGenerationContext context)
        {
            return string.Empty;
        }

        #endregion
    }
}