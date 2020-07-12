using System;
using System.Collections.Generic;
using Angular_ServerSidePagination_BackEnd.Models.User.RequestModels;
using Angular_ServerSidePagination_BackEnd.Models.User.ResponseModel;
using AutoMapper;
using Business.Engine.Interfaces;
using Core.Common.DTOs.UserEngine;
using Core.Common.DTOs.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Angular_ServerSidePagination_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserEngine _userEngine;

        private readonly IMapper _mapper;

        public UserController(IUserEngine userEngine, IMapper mapper)
        {
            _userEngine = userEngine ?? throw new ArgumentNullException(nameof(userEngine));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpPost("GetAllUser")]
        public ActionResult<GetAllUserResponseModel> GetAllUser(UsersFilterRequestModel filter)
        {
            List<UserDto> users = _userEngine.GetAllUser(_mapper.Map<UsersFilterParamsDto>(filter));

            return new GetAllUserResponseModel
            {
                Users = users,
                TotalRecords = users.Count
            };
        }
    }
}