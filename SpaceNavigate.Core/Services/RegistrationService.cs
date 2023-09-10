using Newtonsoft.Json;
using SpaceNavigate.Core.PublicModels.Registration;
using SpaceNavigate.Core.Interfaces;

namespace SpaceNavigate.Core.Services
{
    // All the code in this file is included in all platforms.
    public class RegistrationService : IRegistrationService
    {
        public async Task<HttpResponseMessage> RegistrationAsync(NewRegistration regReq)
        {
            StringContent queryString = new StringContent(JsonConvert.SerializeObject(regReq));
            var response = await ApiCaller.GetHttpResponseAsync("/registration", Enums.HttpMethods.Post, queryString);

            return response;


        }

        public async Task<HttpResponseMessage> VerifyEmailAsync(string email,AuthenticationCode code)
        {
            StringContent queryString = new StringContent(JsonConvert.SerializeObject(code));
            var response = await ApiCaller.GetHttpResponseAsync(string.Format("/registration/{0}/verify",email), Enums.HttpMethods.Post, queryString);

            return response;

        }

        public async Task<HttpResponseMessage> PasswordForEmailAsync(string email, NewPassword psw)
        {
            StringContent queryString = new StringContent(JsonConvert.SerializeObject(psw));
            var response = await ApiCaller.GetHttpResponseAsync(string.Format("/registration/{0}/password", email), Enums.HttpMethods.Post, queryString);

            return response;

        }

        public async Task<HttpResponseMessage> RegistrationDetailAsync(string email,RegistrationDetails detail)
        {
            StringContent queryString = new StringContent(JsonConvert.SerializeObject(detail));
            var response = await ApiCaller.GetHttpResponseAsync(string.Format("/registration/{0}/password", email), Enums.HttpMethods.Post, queryString);

            return response;

        }

    }
}