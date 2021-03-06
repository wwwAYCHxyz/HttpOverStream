﻿using System;
using System.IO;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace HttpOverStream
{
    public interface IListen
    {
        Task StartAsync(Action<Stream> onConnection, CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
        IPrincipal GetTransportIdentity(Stream connection);
    }
}
