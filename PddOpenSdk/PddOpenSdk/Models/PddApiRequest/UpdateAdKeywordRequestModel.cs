using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UpdateAdKeywordRequestModel : PddRequestModel
    {
        /// <summary>
/// 0--搜索广告,1--明星店铺,2--定向广告,3--首页Banner广告（目前只支持0，暂不支持1、2、3）
/// </summary>
[JsonProperty("scene_type")]
public int SceneType {get;set;}
/// <summary>
/// 
/// </summary>
[JsonProperty("keywords")]
public object Keywords {get;set;}

    public partial class KeywordsRequestModel : PddRequestModel
    {
        
}

}
}