using SpaceNavigate.Core.PublicModels.Registration;

namespace SpaceNavigate.Core.Interfaces
{
    public interface IRegistrationService
    {
        Task<HttpResponseMessage> RegistrationAsync(NewRegistration regReq);
        Task<HttpResponseMessage> VerifyEmailAsync(string email, AuthenticationCode code);
        Task<HttpResponseMessage> PasswordForEmailAsync(string email, NewPassword psw);
        Task<HttpResponseMessage> RegistrationDetailAsync(string email, RegistrationDetails detail);
    }
}
