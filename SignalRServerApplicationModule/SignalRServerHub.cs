using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

using System.Threading.Tasks;

 
public class SignalRServerHub: Hub
{
    private readonly ILogger<SignalRServerHub> logger;

    public SignalRServerHub(ILogger<SignalRServerHub> logger)
    {
        this.logger = logger;
    }

    public async Task<string> Signin( string username, string password)
    {
        logger.LogInformation( $"Signin( {username}, {password} )" );
        await Task.CompletedTask;
        if(username == "admin" && password == "p@ssword")
        {
            return "sgdf1423";
        }
        else
        {
            return null;
        }
    }
    

    public async Task<string> OnMessage( string RequestText)
    {
        await Task.CompletedTask;
        return RequestText;
    }
}
 
