// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoremIpsumSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System.Text;

    using AutoPoco.Engine;
    using AutoPoco.Properties;

    /// <summary>
    /// The lorem ipsum source.
    /// </summary>
    public class LoremIpsumSource : DatasourceBase<string>
    {
        #region Fields

        /// <summary>
        /// The times.
        /// </summary>
        private readonly int times;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoremIpsumSource"/> class.
        /// </summary>
        public LoremIpsumSource()
            : this(1)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoremIpsumSource"/> class.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        public LoremIpsumSource(int count)
        {
            this.times = count;
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
            var builder = new StringBuilder(Resources.LoremIpsum);

            for (int i = 1; i < this.times; i++)
            {
                builder.AppendFormat("{0}\r\n\r\n", Resources.LoremIpsum);
            }

            return builder.ToString().Trim();
        }

        #endregion
    }
}