﻿using DistributedServices.BlogBoundedContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;

namespace NLayerApp.DistributedServices.BlogBoundedContext.Tests
{
    public class IntegrationTestsInitialize : IDisposable
    {
        public TestServer server { get; private set; }

        public IntegrationTestsInitialize()
        {
            var hostBuilder = new WebHostBuilder()
                .UseStartup<Startup>();

            server = new TestServer(hostBuilder);
        }
        public void Dispose()
        {

        }
    }
}
