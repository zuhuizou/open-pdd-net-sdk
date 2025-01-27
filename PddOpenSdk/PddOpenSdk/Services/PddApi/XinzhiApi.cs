using PddOpenSdk.Models.Request.Xinzhi;
using PddOpenSdk.Models.Response.Xinzhi;
using System.Threading.Tasks;
namespace PddOpenSdk.Services.PddApi
{
    public class XinzhiApi : PddCommonApi
    {
        /// <summary>
        /// 天气实况
        /// </summary>
        public async Task<GetXinzhiWeatherResponseModel> GetXinzhiWeatherAsync(GetXinzhiWeatherRequestModel getXinzhiWeather)
        {
            var result = await PostAsync<GetXinzhiWeatherRequestModel, GetXinzhiWeatherResponseModel>("pdd.xinzhi.weather.get", getXinzhiWeather);
            return result;
        }

    }
}
