// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ParentSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;

    /// <summary>
    /// The parent source.
    /// </summary>
    /// <typeparam name="T">The Type of parent.</typeparam>
    public class ParentSource<T> : DatasourceBase<T>
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
            // Search upwards for parent
            return this.FindParent(context.Node, false);
        }

        #endregion

        #region Methods

        /// <summary>
        /// The find parent.
        /// </summary>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <param name="foundOne">
        /// The found one.
        /// </param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        private T FindParent(IGenerationContextNode current, bool foundOne)
        {
            if (current == null)
            {
                return default(T);
            }

            if (current.ContextType == GenerationTargetTypes.Object)
            {
                var type = (TypeGenerationContextNode)current;

                if (type.Target is T)
                {
                    return (T)type.Target;
                }
            }

            return this.FindParent(current.Parent, foundOne);
        }

        #endregion
    }
}