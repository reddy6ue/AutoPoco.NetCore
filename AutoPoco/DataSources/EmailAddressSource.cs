// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailAddressSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System;

    using AutoPoco.Engine;

    /// <summary>
    /// The email address source.
    /// </summary>
    public class EmailAddressSource : DatasourceBase<string>
    {
        #region Fields

        /// <summary>
        /// The index.
        /// </summary>
        private int index;

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
            // TODO: See if first name/last name has been used in this context
            return string.Format("{0}@example.com", this.index++);
        }

        #endregion
    }
}