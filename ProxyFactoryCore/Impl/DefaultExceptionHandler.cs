﻿using ProxyFactory.Core.Abstract;
using ProxyFactoryCore.Abstract;
using System;

namespace ProxyFactoryCore.Impl
{
    public class DefaultExceptionHandler : IExceptionHandler
    {
        public void OnException(Exception ex, IInvocationInfo invocationInfo)
        {
            throw ex;
        }
    }
}
