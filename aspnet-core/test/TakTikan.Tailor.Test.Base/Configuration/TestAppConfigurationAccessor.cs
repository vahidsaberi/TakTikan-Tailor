﻿using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using TakTikan.Tailor.Configuration;

namespace TakTikan.Tailor.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(TailorTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
