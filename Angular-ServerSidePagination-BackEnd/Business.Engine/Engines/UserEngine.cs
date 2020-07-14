using System;
using System.Collections.Generic;
using System.Linq;
using Business.Engine.Interfaces;
using Business.Service.Interfaces;
using Core.Common.DTOs.UserEngine;
using Core.Common.DTOs.UserService;
using Core.Extensions;

namespace Business.Engine.Engines
{
    public class UserEngine : IUserEngine
    {
        private readonly IUserService _userService;

        public UserEngine(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public GetAllUserResponseDto GetAllUser(UsersFilterParamsDto filterParams)
        {
            List<UserDto> users = _userService.GetUsersMockData();

            return new GetAllUserResponseDto
            {
                Users = users.AsQueryable()
                    .OrderBy(filterParams.SortModel)
                    .Skip(filterParams.StartRow)
                    .Take(filterParams.EndRow)
                    .ToList(),
                TotalRecords = users.Count
            };
        }
    }
}
