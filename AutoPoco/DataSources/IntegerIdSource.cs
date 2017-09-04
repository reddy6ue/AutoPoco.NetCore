// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IntegerIdSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;

    /// <summary>
    /// The integer id source.
    /// </summary>
    public class IntegerIdSource : DatasourceBase<int>
    {
        #region Fields

        /// <summary>
        /// The current id.
        /// </summary>
        private int currentId;

        #endregion

        #region Public Methods and Operators

        public override int Next(IGenerationContext context)
        {
            return this.currentId++;
        }

        #endregion
    }
}