// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WhenConfiguringPropertyWithParent.cs" company="">
//   
// </copyright>
// <summary>
//   The when configuring property with parent.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AutoPoco.Tests.Integration.Complete
{
    using System.Linq;

    using AutoPoco.DataSources;
    using AutoPoco.Engine;
    using AutoPoco.Testing;

    using NUnit.Framework;

    /// <summary>
    /// The when configuring property with parent.
    /// </summary>
    [TestFixture]
    public class WhenConfiguringPropertyWithParent
    {
        #region Public Methods and Operators

        /// <summary>
        /// The property_ is_ set_ with_ null_ value_ if_ no_ parent_ exists.
        /// </summary>
        [Test]
        public void Property_Is_Set_With_Null_Value_If_No_Parent_Exists()
        {
            IGenerationSession session = AutoPocoContainer.Configure(
                x =>
                    {
                        x.Include<SimpleNode>().Setup(y => y.Children).Collection(1, 1);
                    }).CreateSession();

            var node = session.Next<SimpleNode>();

            Assert.Null(node.Parent);
        }

        /// <summary>
        /// The property_ is_ set_ with_ parent_ value_ if_ parent_ exists.
        /// </summary>
        [Test]
        public void Property_Is_Set_With_Parent_Value_If_Parent_Exists()
        {
			// TODO: This test fails. Fix it --Praneeth
            IGenerationSession session = AutoPocoContainer.Configure(
                x => x.Include<SimpleNode>()
                         .Setup(y => y.Children).Collection(1, 1)
                         .Setup(y => y.Parent).Use<ParentSource<SimpleNode>>()).CreateSession();

            var node = session.Next<SimpleNode>();
			Assert.AreEqual(node, node.Children.First().Parent);
        }

        #endregion
    }
}