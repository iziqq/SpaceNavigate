using Newtonsoft.Json;
using SpaceNavigate.Core.PublicModels.User;
using SpaceNavigate.Core.Interfaces;

namespace SpaceNavigate.Core.Services
{
    // All the code in this file is included in all platforms.
    public class UserService : IUserService
    {
        public async Task<HttpResponseMessage> LoginAsync(UserLogin user)
        {
            StringContent queryString = new StringContent(JsonConvert.SerializeObject(user));
            var response = await ApiCaller.GetHttpResponseAsync("/users", Enums.HttpMethods.Post, queryString);

            return response;

        }

    }
}