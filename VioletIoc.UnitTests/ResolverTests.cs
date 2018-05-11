﻿using Xunit;
using System;

namespace VioletIoc.UnitTests
{
    public class ResolverTests
    {
        [Fact]
        public void Resolver_ResolvesToInstance()
        {
            var service = new TestService();
            var locator = ContainerFactory.CreateRootContainer();  
            locator.RegisterSingleton<ITestService>(service);

            var instance = locator.ResolverFor<ITestService>().Resolve();

            Assert.Equal(service, instance);
        }
    }
}
