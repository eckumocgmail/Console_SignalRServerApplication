
using Microsoft.AspNetCore.SignalR;

using System;
using System.Threading.Tasks;

internal class FilterConsoleLogger : IHubFilter
{
 
    internal async ValueTask<object?> InvokeMethodAsync(
        HubInvocationContext invocationContext, 
        Func<HubInvocationContext, ValueTask<object?>> next)
    {
        Console.WriteLine(invocationContext.HubMethodName);
        return await next(invocationContext);        
    }   
}

