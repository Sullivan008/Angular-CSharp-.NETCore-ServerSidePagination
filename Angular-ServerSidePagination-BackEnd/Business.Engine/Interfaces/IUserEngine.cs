using System.Collections.Generic;
using Core.Common.DTOs.UserEngine;
using Core.Common.DTOs.UserService;

namespace Business.Engine.Interfaces
{
    public interface IUserEngine
    {
        List<UserDto> GetAllUser(UsersFilterParamsDto filterParams);
    }
}
