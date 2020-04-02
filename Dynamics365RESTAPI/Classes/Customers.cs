using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365RESTAPI.Classes
{
    class Customers
    {
        public class CustomersOData
        {
            [JsonProperty("odata.metadata")]
            public string Metadata { get; set; }
            public List<Customer> value { get; set; }
        }

        public List<Customer> customers { get; set; }

        public void GetCustomers(HttpClient _client, string _resource)
        {
            string requestUrl = _resource + "/data/CustomersV3";

            Task<HttpResponseMessage> resp = _client.GetAsync(requestUrl);
            resp.Wait();

            var responseContent = resp.Result.Content.ReadAsStringAsync();
            var rawJSON = responseContent.Result.ToString();

            var customerGroupsOData = JsonConvert.DeserializeObject<CustomersOData>(rawJSON);

            customers = customerGroupsOData.value;
        }
    }
}
