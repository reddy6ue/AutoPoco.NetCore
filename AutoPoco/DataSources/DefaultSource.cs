// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System;

    using AutoPoco.Engine;

    /// <summary>
    /// The default source.
    /// </summary>
    /// <typeparam name="T">The type to generate the default value of</typeparam>
    public class DefaultSource<T> : DatasourceBase<T>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The next.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public override T Next(IGenerationContext context)
        {
            if (typeof(T).IsValueType)
            {
                return default(T);
            }

            return Activator.CreateInstance<T>();
        }

        #endregion
    }
}