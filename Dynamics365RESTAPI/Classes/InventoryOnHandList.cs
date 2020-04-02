using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365RESTAPI.Classes
{
    class InventoryOnHandList
    {
        public class InventoryOnHandListOData
        {
            [JsonProperty("odata.metadata")]
            public string Metadata { get; set; }
            public List<InventoryOnHand> value { get; set; }
        }

        public List<InventoryOnHand> inventoryOnHand { get; set; }

        public void GetInventoryOnHandList(HttpClient _client, string _resource)
        {
            string requestUrl = _resource + "/data/InventorySitesOnHand";

            Task<HttpResponseMessage> resp = _client.GetAsync(requestUrl);
            resp.Wait();

            var responseContent = resp.Result.Content.ReadAsStringAsync();
            var rawJSON = responseContent.Result.ToString();

            var inventoryOnHandOData = JsonConvert.DeserializeObject<InventoryOnHandListOData>(rawJSON);

            inventoryOnHand = inventoryOnHandOData.value;
        }
    }
}
