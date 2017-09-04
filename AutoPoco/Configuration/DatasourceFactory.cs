using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoPoco.Engine;

namespace AutoPoco.Configuration
{
    public class DatasourceFactory : IEngineConfigurationDatasource
    {
        private Type mDatasourceType;
        private Object[] mParams;

        public DatasourceFactory(Type t)
        {
            mDatasourceType = t;
        }

        public void SetParams(params Object[] args)
        {
            mParams = args;
        }

        public AutoPoco.Engine.IDatasource Build()
        {
            return Activator.CreateInstance(mDatasourceType, mParams) as IDatasource;
        }
    }
}
