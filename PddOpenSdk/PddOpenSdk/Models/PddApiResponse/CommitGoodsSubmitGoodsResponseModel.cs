using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class CommitGoodsSubmitGoodsResponseModel : PddResponseModel
    {
        /// <summary>
/// 返回response
/// </summary>
[JsonProperty("goods_update_response")]
public object GoodsUpdateResponse {get;set;}

    public partial class GoodsUpdateResponseResponseModel : PddResponseModel
    {
        
}

}
}