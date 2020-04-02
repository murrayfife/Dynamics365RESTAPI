using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using Dynamics365RESTAPI.Helpers;
using Dynamics365RESTAPI.Classes;
using System.Net.Http.Headers;

namespace Dynamics365RESTAPI
{
    public static class RestAPI
    {
        static string environmentId = "mufifed365msdemo1470e6a7a3ffef9b1aos";

        [FunctionName("GetCustomerGroups")]
        public static async Task<IActionResult> GetCustomerGroups(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string resource = "https://" + environmentId + ".cloudax.dynamics.com";
            HttpClient client = new HttpClient();

            AuthenticationHelper bearerToken = new AuthenticationHelper();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.GetBearerToken(environmentId).Result.AccessToken.ToString());

            CustomerGroups customerGroups = new CustomerGroups();
            customerGroups.GetCustomerGroups(client, resource);
            
            string responseMessage = JsonConvert.SerializeObject(customerGroups);

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("GetCustomers")]
        public static async Task<IActionResult> GetCustomers(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string resource = "https://" + environmentId + ".cloudax.dynamics.com";
            HttpClient client = new HttpClient();

            AuthenticationHelper bearerToken = new AuthenticationHelper();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.GetBearerToken(environmentId).Result.AccessToken.ToString());

            Customers customers = new Customers();
            customers.GetCustomers(client, resource);

            string responseMessage = JsonConvert.SerializeObject(customers);

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("GetInventoryOnHandList")]
        public static async Task<IActionResult> GetInventoryOnHandList(
             [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
             ILogger log)
        {
            string resource = "https://" + environmentId + ".cloudax.dynamics.com";
            HttpClient client = new HttpClient();

            AuthenticationHelper bearerToken = new AuthenticationHelper();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.GetBearerToken(environmentId).Result.AccessToken.ToString());

            InventoryOnHandList inventoryOnHandList = new InventoryOnHandList();
            inventoryOnHandList.GetInventoryOnHandList(client, resource);

            string responseMessage = JsonConvert.SerializeObject(inventoryOnHandList);

            return new OkObjectResult(responseMessage);
        }

        [FunctionName("GetProductList")]
        public static async Task<IActionResult> GetProductList(
     [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
     ILogger log)
        {
            string resource = "https://" + environmentId + ".cloudax.dynamics.com";
            HttpClient client = new HttpClient();

            AuthenticationHelper bearerToken = new AuthenticationHelper();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.GetBearerToken(environmentId).Result.AccessToken.ToString());

            ProductList productList = new ProductList();
            productList.GetProductList(client, resource);

            string responseMessage = JsonConvert.SerializeObject(productList);

            return new OkObjectResult(responseMessage);
        }
    }
}
