// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LastNameSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The last name source.
    /// </summary>
    public class LastNameSource : DatasourceBase<string>
    {
        #region Static Fields

        /// <summary>
        ///     The list of random last names
        /// </summary>
        private static readonly string[] LastNames =
            {
                "White", "Black", "Red", "Gray", "Magenta", "Myrtle", "Gold", 
                "Silver", "Green", "Puce", "Carmine", "Purple", "Yellow", 
                "Indigo"
            };

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
        public override string Next(IGenerationContext context)
        {
            return LastNames[RandomNumberGenerator.Current.Next(0, LastNames.Length)];
        }

        #endregion
    }
}