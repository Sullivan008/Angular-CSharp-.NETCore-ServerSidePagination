using Core.Common.DTOs.UserEngine;

namespace Business.Engine.Interfaces
{
    public interface IUserEngine
    {
        GetAllUserResponseDto GetAllUser(UsersFilterParamsDto filterParams);
    }
}
