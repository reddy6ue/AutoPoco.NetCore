// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsStatesSource.cs" company="AutoPoco">
//   Microsoft Public License (Ms-PL)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.DataSources
{
    using System.Collections.Generic;
    using System.Linq;

    using AutoPoco.Engine;
    using AutoPoco.Util;

    /// <summary>
    /// The us states source.
    /// </summary>
    public class UsStatesSource : DatasourceBase<string>
    {
        #region Static Fields

        /// <summary>
        /// The states.
        /// </summary>
        public static readonly Dictionary<string, string> States = 
            new Dictionary<string, string>
                                                                       {
                                                                           { "AL", "Alabama" }, { "AK", "Alaska" }, 
                                                                           { "AZ", "Arizona" }, { "AR", "Arkansas" }, 
                                                                           { "CA", "California" }, { "CO", "Colorado" }, 
                                                                           { "CT", "Connecticut" }, { "DE", "Delaware" }, 
                                                                           { "FL", "Florida" }, { "GA", "Georgia" }, 
                                                                           { "HI", "Hawaii" }, { "ID", "Idaho" }, 
                                                                           { "IL", "Illinois" }, { "IN", "Indiana" }, 
                                                                           { "IA", "Iowa" }, { "KS", "Kansas" }, 
                                                                           { "KY", "Kentucky" }, { "LA", "Louisiana" }, 
                                                                           { "ME", "Maine" }, { "MD", "Maryland" }, 
                                                                           { "MA", "Massachusetts" }, { "MI", "Michigan" }, 
                                                                           { "MN", "Minnesota" }, 
                                                                           {
                                                                               "MS", 
                                                                               "Mississippi"
                                                                           }, 
                                                                           { "MO", "Missouri" }, 
                                                                           { "MT", "Montana" }, 
                                                                           { "NE", "Nebraska" }, 
                                                                           { "NV", "Nevada" }, 
                                                                           {
                                                                               "NH", 
                                                                               "New Hampshire"
                                                                           }, 
                                                                           {
                                                                               "NJ", "New Jersey"
                                                                           }, 
                                                                           {
                                                                               "NM", "New Mexico"
                                                                           }, 
                                                                           { "NY", "New York" }, 
                                                                           {
                                                                               "NC", 
                                                                               "North Carolina"
                                                                           }, 
                                                                           {
                                                                               "ND", 
                                                                               "North Dakota"
                                                                           }, 
                                                                           { "OH", "Ohio" }, 
                                                                           { "OK", "Oklahoma" }, 
                                                                           { "OR", "Oregon" }, 
                                                                           {
                                                                               "PA", 
                                                                               "Pennsylvania"
                                                                           }, 
                                                                           {
                                                                               "RI", 
                                                                               "Rhode Island"
                                                                           }, 
                                                                           {
                                                                               "SC", 
                                                                               "South Carolina"
                                                                           }, 
                                                                           {
                                                                               "SD", 
                                                                               "South Dakota"
                                                                           }, 
                                                                           {
                                                                               "TN", "Tennessee"
                                                                           }, 
                                                                           { "TX", "Texas" }, 
                                                                           { "UT", "Utah" }, 
                                                                           { "VT", "Vermont" }, 
                                                                           { "VA", "Virginia" }, 
                                                                           {
                                                                               "WA", "Washington"
                                                                           }, 
                                                                           {
                                                                               "WV", 
                                                                               "West Virginia"
                                                                           }, 
                                                                           {
                                                                               "WI", "Wisconsin"
                                                                           }, 
                                                                           { "WY", "Wyoming" }, 
                                                                           {
                                                                               "AS", 
                                                                               "American Samoa"
                                                                           }, 
                                                                           {
                                                                               "DC", 
                                                                               "District of Columbia"
                                                                           }, 
                                                                           {
                                                                               "FM", 
                                                                               "Federated States of Micronesia"
                                                                           }, 
                                                                           {
                                                                               "MH", 
                                                                               "Marshall Islands"
                                                                           }, 
                                                                           {
                                                                               "MP", 
                                                                               "Northern Mariana Islands"
                                                                           }, 
                                                                           { "PW", "Palau" }, 
                                                                           {
                                                                               "PR", 
                                                                               "Puerto Rico"
                                                                           }, 
                                                                           {
                                                                               "VI", 
                                                                               "Virgin Islands"
                                                                           }, 
                                                                           { "GU", "Guam" }
                                                                       };

        #endregion

        #region Fields

        /// <summary>
        /// The use abbreviations.
        /// </summary>
        private readonly bool useAbbreviations;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UsStatesSource"/> class.
        /// </summary>
        public UsStatesSource()
            : this(false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsStatesSource"/> class.
        /// </summary>
        /// <param name="useAbbreviations">
        /// The use abbreviations.
        /// </param>
        public UsStatesSource(bool useAbbreviations)
        {
            this.useAbbreviations = useAbbreviations;
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
            int num = RandomNumberGenerator.Current.Next(0, States.Count);

            return this.useAbbreviations ? States.Keys.ToList()[num] : States.Values.ToList()[num];
        }

        #endregion
    }
}