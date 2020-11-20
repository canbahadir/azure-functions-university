using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsUniversity.Demo
{
    public static class NewPlayerQueueTrigger
    {
        [FunctionName("NewPlayerQueueTrigger")]
        public static void Run(
            [QueueTrigger("newplayer-items", 
            Connection = "azfuncstor_STORAGE")]string myQueueItem, 
            ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
