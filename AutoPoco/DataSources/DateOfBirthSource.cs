// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateOfBirthSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System;

    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The date of birth source.
    /// </summary>
    public class DateOfBirthSource : DatasourceBase<DateTime>
    {
        #region Fields

        /// <summary>
        /// The years max.
        /// </summary>
        private readonly int yearsMax;

        /// <summary>
        /// The years min.
        /// </summary>
        private readonly int yearsMin;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DateOfBirthSource"/> class.
        /// </summary>
        public DateOfBirthSource()
            : this(16, 59)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateOfBirthSource"/> class.
        /// </summary>
        /// <param name="min">
        /// The min.
        /// </param>
        /// <param name="max">
        /// The max.
        /// </param>
        public DateOfBirthSource(int min, int max)
        {
            this.yearsMax = max;
            this.yearsMin = min;
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
        /// The <see cref="DateTime"/>.
        /// </returns>
        public override DateTime Next(IGenerationContext context)
        {
            int year = DateTime.Now.Year - RandomNumberGenerator.Current.Next(this.yearsMin, this.yearsMax);
            int day = RandomNumberGenerator.Current.Next(1, 28);
            int month = RandomNumberGenerator.Current.Next(1, 12);

            return new DateTime(year, month, day);
        }

        #endregion
    }
}