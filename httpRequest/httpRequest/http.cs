using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace httpRequest
{
    public class http
    {
        public async Task<string> PageAsync()
        {
            string page = "http://127.0.0.1";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(page);
            HttpContent content = response.Content;
            string result = await content.ReadAsStringAsync();
            var finalResult = JsonConvert.SerializeObject(result.Substring(0));
            if (result != null)
            {
                finalResult.ToString();
            }
            return finalResult;
        }
    }
}
