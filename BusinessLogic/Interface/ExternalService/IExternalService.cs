using System.Net.Http;

namespace BusinessLogic.Interface.ExternalService
{
    public interface IExternalService
    {
        /// <summary>
        /// Method that makes an external API call
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="inut2"></param>
        /// <returns></returns>
        HttpResponseMessage GetDataFromExternalApi(string input1, string inut2); 
    }
}
