﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Aggregates.Messages;

namespace Aggregates.Contracts
{
    public interface IProcessor
    {
        Task<IEnumerable<TResponse>> Process<TQuery, TResponse>(TQuery query) where TQuery : IQuery<TResponse>;
    }
}
