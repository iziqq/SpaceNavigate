using SpaceNavigate.Core.PublicModels.User;

namespace SpaceNavigate.Core.Interfaces
{
    public interface IUserService
    {
        Task<HttpResponseMessage> LoginAsync(UserLogin user);
    }
}
