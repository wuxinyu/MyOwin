using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendService.Test.Common
{
    using System.Net.Http;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;

    public static class HttpExtension
    {
        public static HttpContent ToGeneralJsonContent(this object originObject)
        {
            var json = JsonConvert.SerializeObject(originObject);
            var content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        }

        public static string ToJson(this HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
