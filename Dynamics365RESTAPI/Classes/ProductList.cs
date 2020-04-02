using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics365RESTAPI.Classes
{
    class ProductList
    {
        public class ProductListOData
        {
            [JsonProperty("odata.metadata")]
            public string Metadata { get; set; }
            public List<Product> value { get; set; }
        }

        public List<Product> products { get; set; }

        public void GetProductList(HttpClient _client, string _resource)
        {
            string requestUrl = _resource + "/data/ReleasedDistinctProducts";

            Task<HttpResponseMessage> resp = _client.GetAsync(requestUrl);
            resp.Wait();

            var responseContent = resp.Result.Content.ReadAsStringAsync();
            var rawJSON = responseContent.Result.ToString();

            var productOData = JsonConvert.DeserializeObject<ProductListOData>(rawJSON);

            products = productOData.value;
        }
    }
}
