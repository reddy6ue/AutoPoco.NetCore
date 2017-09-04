// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumerableSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace AutoPoco.DataSources
{
    using System.Collections.Generic;

    using AutoPoco.Configuration;
    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// Allows you to use another Source to generate an enumerable collection
    /// </summary>
    /// <typeparam name="TSource">
    /// The type of the source.
    /// </typeparam>
    /// <typeparam name="T">
    /// </typeparam>
    public class EnumerableSource<TSource, T> : DatasourceBase<IEnumerable<T>>
        where TSource : IDatasource<T>
    {
        #region Fields

        /// <summary>
        /// The args.
        /// </summary>
        private readonly object[] args;

        /// <summary>
        /// The max count.
        /// </summary>
        private readonly int maxCount;

        /// <summary>
        /// The min count.
        /// </summary>
        private readonly int minCount;

        /// <summary>
        /// The source.
        /// </summary>
        private readonly IDatasource<T> source;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerableSource{TSource,T}"/> class.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        public EnumerableSource(int count)
            : this(count, count, new object[] { })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerableSource{TSource,T}"/> class.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        public EnumerableSource(int count, object[] args)
            : this(count, count, args)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerableSource{TSource,T}"/> class.
        /// </summary>
        /// <param name="min">
        /// The min.
        /// </param>
        /// <param name="max">
        /// The max.
        /// </param>
        public EnumerableSource(int min, int max)
            : this(min, max, new object[] { })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumerableSource{TSource,T}"/> class.
        /// </summary>
        /// <param name="minCount">
        /// The min count.
        /// </param>
        /// <param name="maxCount">
        /// The max count.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        public EnumerableSource(int minCount, int maxCount, object[] args)
        {
            this.minCount = minCount;
            this.maxCount = maxCount;
            this.args = args;

            var factory = new DatasourceFactory(typeof(TSource));
            factory.SetParams(this.args);
            this.source = (IDatasource<T>)factory.Build();
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
        /// The next in the generation of list of T
        /// </returns>
        public override IEnumerable<T> Next(IGenerationContext context)
        {
            int count = RandomNumberGenerator.Current.Next(this.minCount, this.maxCount + 1);
            for (int i = 0; i < count; i++)
            {
                yield return (T)this.source.Next(context);
            }
        }

        #endregion
    }
}