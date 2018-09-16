using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryDdkOauthGoodsPidResponseModel : PddResponseModel
    {
        /// <summary>
/// 多多进宝推广位对象列表
/// </summary>
[JsonProperty("p_id_list")]
public object PIdList {get;set;}
/// <summary>
/// 返回推广位总数
/// </summary>
[JsonProperty("total_count")]
public int TotalCount {get;set;}

    public partial class PIdListResponseModel : PddResponseModel
    {
        
}

}
}