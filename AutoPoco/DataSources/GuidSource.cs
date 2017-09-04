using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    using AutoPoco.Util;

    public class GuidSource : DatasourceBase<Guid>
    {
        public override Guid Next(IGenerationContext context)
        {
            byte[] buffer = new byte[16];
            RandomNumberGenerator.Current.NextBytes(buffer);

            return new Guid(buffer);
        }
    }
}