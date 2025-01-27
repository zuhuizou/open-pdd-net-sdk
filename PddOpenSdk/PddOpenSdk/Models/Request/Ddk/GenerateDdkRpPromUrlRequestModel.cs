using Newtonsoft.Json;
using System.Collections.Generic;
namespace PddOpenSdk.Models.Request.Ddk
{
    public partial class GenerateDdkRpPromUrlRequestModel : PddRequestModel
    {
        /// <summary>
        /// 是否生成短链接。true-是，false-否，默认false
        /// </summary>
        [JsonProperty("generate_short_url")]
        public bool? GenerateShortUrl { get; set; }
        /// <summary>
        /// 推广位列表，例如：["60005_612"]
        /// </summary>
        [JsonProperty("p_id_list")]
        public List<string> PIdList { get; set; }
        /// <summary>
        /// 自定义参数，为链接打上自定义标签。自定义参数最长限制64个字节。
        /// </summary>
        [JsonProperty("custom_parameters")]
        public string CustomParameters { get; set; }
        /// <summary>
        /// 是否唤起微信客户端， 默认false 否，true 是
        /// </summary>
        [JsonProperty("generate_weapp_webview")]
        public bool GenerateWeappWebview { get; set; }
        /// <summary>
        /// 唤起微信app推广短链接
        /// </summary>
        [JsonProperty("we_app_web_view_short_url")]
        public bool? WeAppWebViewShortUrl { get; set; }
        /// <summary>
        /// 唤起微信app推广链接
        /// </summary>
        [JsonProperty("we_app_web_wiew_url")]
        public bool? WeAppWebWiewUrl { get; set; }
        /// <summary>
        /// 是否生成小程序推广
        /// </summary>
        [JsonProperty("generate_we_app")]
        public bool? GenerateWeApp { get; set; }
        /// <summary>
        /// CPA新人红包，0-默认红包，2 – 新人红包，默认0
        /// </summary>
        [JsonProperty("channel_type")]
        public int? ChannelType { get; set; }
        /// <summary>
        /// 是否返回 schema URL
        /// </summary>
        [JsonProperty("generate_schema_url")]
        public bool? GenerateSchemaUrl { get; set; }

    }

}
