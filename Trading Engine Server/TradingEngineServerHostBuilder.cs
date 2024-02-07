﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TradingEngineServer.Core.Configuration;

namespace TradingEngineServer.Core
{
    public sealed class TradingEngineServerHostBuilder
    {

        public static IHost BuildTradingEngineServer()
            => Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                // Start with Configuration
                services.AddOptions();
                services.Configure<TradingEngiveServerConfiguration>(context.Configuration.GetSection(nameof(TradingEngiveServerConfiguration)));

                // Add Singleton objects.
                services.AddSingleton<ITradingEngineServer, TradingEngineServer>();

                // Add hosted service.
                services.AddHostedService<TradingEngineServer>(); 
            }).Build();          
    }
}
