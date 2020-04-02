using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365RESTAPI.Classes
{
    class CustomerGroups
    {
        public class CustomerGroupsOData
        {
            [JsonProperty("odata.metadata")]
            public string Metadata { get; set; }
            public List<CustomerGroup> value { get; set; }
        }

        public List<CustomerGroup> customerGroups { get; set; }

        public void GetCustomerGroups(HttpClient _client, string _resource)
        {
            string requestUrl = _resource + "/data/CustomerGroups";

            Task<HttpResponseMessage> resp = _client.GetAsync(requestUrl);
            resp.Wait();

            var responseContent = resp.Result.Content.ReadAsStringAsync();
            var rawJSON = responseContent.Result.ToString();

            var customerGroupsOData = JsonConvert.DeserializeObject<CustomerGroupsOData>(rawJSON);

            customerGroups = customerGroupsOData.value;
        }
    }
}
