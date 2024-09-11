// using System.IO;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Azure.WebJobs.Extensions.Http;
// using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.Logging;
// using Newtonsoft.Json;
// using System.Net.Http;
// using System.Text;



// namespace Company.Function
// {
//     public static class GetResumeCounternew
//     {
//         [FunctionName("GetResumeCounternew")]
//         public static async Task<HttpResponseMessage> Run(
//             [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
//             [CosmosDB(
//                 databaseName: "AzureResume",
//                 containerName: "Counter",
//                 Connection  = "AzureResumeConnectionString",
//                 Id = "1",
//                 PartitionKey = "1")] Counter counter,
//             [CosmosDB(
//                 databaseName: "AzureResume",
//                 containerName: "Counter",
//                 Connection  = "AzureResumeConnectionString")] IAsyncCollector<Counter> counterCollector,
//             ILogger log)
//         {
//             log.LogInformation("C# HTTP trigger function processed a request.");

//             if (counter == null)
//             {
//                 // Initialize the counter if it doesn't exist
//                 counter = new Counter { Id = "1", Count = 1 };
//             }
//             else
//             {
//                 // Increment the existing counter
//                 counter.Count += 1;
//             }

//             // Add or update the counter in the database
//             await counterCollector.AddAsync(counter);

//             var jsonToReturn = JsonConvert.SerializeObject(counter);

//             return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
//             {
//                 Content = new StringContent(jsonToReturn, Encoding.UTF8, "application/json")
//             };
//         }
//     }
// }
 



// using System.IO;
// using System.Net.Http;
// using System.Text;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Azure.WebJobs;
// using Microsoft.Azure.WebJobs.Extensions.Http;
// using Microsoft.AspNetCore.Http;
// using Microsoft.Extensions.Logging;
// using Newtonsoft.Json;
// using System.Threading.Tasks;

// namespace Company.Function
// {
//     public static class GetResumeCounternew
//     {
//         [FunctionName("GetResumeCounternew")]
//         public static  System.Net.Http.HttpResponseMessage Run(
//             [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
//             [CosmosDB(
//                 databaseName: "AzureResume",
//                 containerName: "Counter",
//                 Connection = "AzureResumeConnectionString",
//                 Id = "1",
//                 PartitionKey = "1")] Counter counter,
//             [CosmosDB(
//                 databaseName: "AzureResume",
//                 containerName: "Counter",
//                 Connection = "AzureResumeConnectionString")] ICollector<Counter> counterCollector,
//             ILogger log)
//         {
//             log.LogInformation("C# HTTP trigger function processed a request.");

//             if (counter == null)
//             {
//                 // Initialize the counter if it doesn't exist
//                 counter = new Counter { Id = "1", Count = 1 };
//             }
//             else
//             {
//                 // Increment the existing counter
//                 counter.Count += 1;
//             }

//             // Add or update the counter in the database
//             counterCollector.Add(counter);

//             var jsonToReturn = JsonConvert.SerializeObject(counter);

//             return new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.OK)
//             {
//                 Content = new System.Net.Http.StringContent(jsonToReturn, Encoding.UTF8, "application/json")
//             };
//         }
//     }
// }
