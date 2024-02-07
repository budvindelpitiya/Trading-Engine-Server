using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Core
{
    public interface ITradingEngineServer
    {
        Task Run(CancellationToken token);
    }
}
