using MiSistema.Core.Interfaces;
using MiSistema.Core.Models;

namespace MiSistema.Core.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
}