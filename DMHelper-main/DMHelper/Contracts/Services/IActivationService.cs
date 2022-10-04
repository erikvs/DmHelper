using System.Threading.Tasks;

namespace DMHelper.Contracts.Services
{
    public interface IActivationService
    {
        Task ActivateAsync(object activationArgs);
    }
}
