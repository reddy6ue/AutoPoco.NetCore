// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreditCardSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The credit card source.
    /// </summary>
    public class CreditCardSource : DatasourceBase<string>
    {
        #region Fields

        /// <summary>
        /// The m preferred.
        /// </summary>
        private readonly CreditCardType preferred;
        
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardSource"/> class.
        /// </summary>
        public CreditCardSource()
            : this(CreditCardType.Random)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardSource"/> class.
        /// </summary>
        /// <param name="preferred">
        /// The preferred.
        /// </param>
        public CreditCardSource(CreditCardType preferred)
        {
            this.preferred = preferred;
        }

        #endregion

        #region Enums

        /// <summary>
        /// The credit card type.
        /// </summary>
        public enum CreditCardType
        {
            /// <summary>
            /// The random.
            /// </summary>
            Random = 0, 

            /// <summary>
            /// The master card.
            /// </summary>
            MasterCard = 1, 

            /// <summary>
            /// The visa.
            /// </summary>
            Visa = 2, 

            /// <summary>
            /// The american express.
            /// </summary>
            AmericanExpress = 3, 

            /// <summary>
            /// The discover.
            /// </summary>
            Discover = 4
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
            CreditCardType cardType = this.preferred;

            if (this.preferred == CreditCardType.Random)
            {
                cardType = (CreditCardType)RandomNumberGenerator.Current.Next(1, 4);
            }

            // TODO: Actually generate numbers
            switch (cardType)
            {
                case CreditCardType.AmericanExpress:
                    return "3782 822463 10005";
                case CreditCardType.Discover:
                    return "6011 1111 1111 1117";
                case CreditCardType.MasterCard:
                    return "5105 1051 0510 5100";
                case CreditCardType.Visa:
                    return "4111 1111 1111 1111";
                default:
                    return null;
            }
        }

        #endregion
    }
}