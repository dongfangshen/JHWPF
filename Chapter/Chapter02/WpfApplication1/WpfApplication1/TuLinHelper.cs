using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using DalSoft.RestClient;

namespace WpfApplication1
{
    public class TuLinHelper
    {
        //api地址 http://www.tuling123.com/openapi/api
        //api key 1ad7635d3dbf45af8661abdc2dbf4264
        //secret 54a51d0dbdc467ee
        private readonly string apiUrl = "http://www.tuling123.com/openapi/api";
        private readonly string apiKey = "1ad7635d3dbf45af8661abdc2dbf4264";
        public async Task<string> GetText(string info)
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("key", apiKey);
            dic.Add("info", info);
            var response = await client.PostAsync(apiUrl, new FormUrlEncodedContent(dic));
            var responseValue = await response.Content.ReadAsStringAsync();
            JObject obj = JObject.Parse(responseValue);
            if (obj.Count > 0)
            {
                return obj["text"]?.ToString() ?? "无内容";
            }
            return "调用无消息";
        }

      
    }
}
