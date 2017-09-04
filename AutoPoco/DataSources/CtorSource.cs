// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CtorSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System;
    using System.Linq;
    using System.Reflection;

    using AutoPoco.Engine;

    /// <summary>
    /// The ctor source.
    /// </summary>
    /// <typeparam name="T">The type to create</typeparam>
    public class CtorSource<T> : DatasourceBase<T>
    {
        #region Fields

        /// <summary>
        /// The m constructor info.
        /// </summary>
        private readonly ConstructorInfo constructorInfo;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CtorSource{T}" /> class.
        /// </summary>
        /// <param name="constructor">The constructor.</param>
        public CtorSource(ConstructorInfo constructor)
        {
            this.constructorInfo = constructor;
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
        /// The <see cref="T"/>.
        /// </returns>
        public override T Next(IGenerationContext context)
        {
            // TODO: May actually create a parallel set of interfaces for doing non-generic requests to session
            // This would negate the need for that awful reflection
            object[] args = this.constructorInfo.GetParameters().Select(
                x =>
                    {
                        MethodInfo method = context.GetType().GetMethod("Next", Type.EmptyTypes);
                        MethodInfo target = method.MakeGenericMethod(x.ParameterType);
                        return target.Invoke(context, null);
                    }).ToArray();

            return (T)this.constructorInfo.Invoke(args);
        }

        #endregion
    }
}