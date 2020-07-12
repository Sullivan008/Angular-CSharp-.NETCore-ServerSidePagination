using System.Collections.Generic;
using Core.Common.DTOs.UserService;

namespace Business.Service.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetUsersMockData();
    }
}
