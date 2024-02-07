using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using TradingEngineServer.Core.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TradingEngineServer.Core
{
    sealed class TradingEngineServer : BackgroundService, ITradingEngineServer
    {
        private readonly ILogger<TradingEngineServer> _logger;
        private readonly TradingEngiveServerConfiguration _TradingEngineServerConfig;
        
         public TradingEngineServer(ILogger<TradingEngineServer> logger,
             IOptions<TradingEngiveServerConfiguration> config) 
         {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _TradingEngineServerConfig = config.Value ?? throw new ArgumentNullException(nameof(config));
         }

        public Task Run(CancellationToken token) => ExecuteAsync(token);
        

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"started {nameof(TradingEngineServer)}");

        while (!stoppingToken.IsCancellationRequested)
        {
   
        }
         _logger.LogInformation($"stopping {nameof(TradingEngineServer)}");
          return Task.CompletedTask;
        }
    }
}
