using AutoPoco.Engine;
using NUnit.Framework;

namespace AutoPoco.Tests.Unit
{
	[TestFixture]
    public class AutoPocoContainerTests
    {
        [Test]
        public void Configure_RunsActions()
        {
            bool hasRun = false;
            AutoPocoContainer.Configure(x =>
            {
                hasRun = true;
            });
            Assert.IsTrue(hasRun);
        }

        [Test]
        public void Configure_ReturnsFactory()
        {
            IGenerationSessionFactory factory = AutoPocoContainer.Configure(x =>
            {
                
            });
            Assert.NotNull(factory);
        }
    }
}
