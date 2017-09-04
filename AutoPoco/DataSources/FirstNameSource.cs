// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstNameSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The first name source.
    /// </summary>
    public class FirstNameSource : DatasourceBase<string>
    {
        #region Static Fields

        /// <summary>
        /// The first names.
        /// </summary>
        private static readonly string[] FirstNames =
        {
            "Jack", "Thomas", "Oliver", "Joshua", "Harry", "Charlie", "Daniel", "William", "James", "Alfie", "Samuel", "George", "Megan", 
            "Joseph", "Benjamin", "Ethan", "Lewis", "Mohammed", "Jake", "Dylan", "Jacob", "Ruby", "Olivia", "Grace", "Emily", "Jessica", 
            "Chloe", "Lily", "Mia", "Lucy", "Amelia", "Evie", "Ella", "Katie", "Ellie", "Charlotte", "Summer", "Mohammed", "Hannah", "Ava"
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
            return FirstNames[RandomNumberGenerator.Current.Next(0, FirstNames.Length)];
        }

        #endregion
    }
}