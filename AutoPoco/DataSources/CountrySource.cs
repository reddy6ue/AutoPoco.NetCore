// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CountrySource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System;
    using System.Globalization;
    using System.Linq;

    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The country source.
    /// </summary>
    public class CountrySource : DatasourceBase<string>
    {
        #region Fields

        /// <summary>
        /// The m cultures.
        /// </summary>
        private readonly CultureInfo[] cultures;
        
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CountrySource"/> class.
        /// </summary>
        public CountrySource()
        {
            this.cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
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
        public override string Next(IGenerationContext context)
        {
            string country;

            do
            {
                int index = RandomNumberGenerator.Current.Next(1, this.cultures.Count());
                country = this.cultures[index].EnglishName;
            }
            while (country.Contains(","));

            int startIndex = country.IndexOf("(", StringComparison.Ordinal) + 1;
            country = country.Substring(startIndex).Replace(")", string.Empty);

            return country;
        }

        #endregion
    }
}