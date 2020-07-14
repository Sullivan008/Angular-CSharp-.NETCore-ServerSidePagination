using System;
using Angular_ServerSidePagination_BackEnd.Models.User.RequestModels;
using Angular_ServerSidePagination_BackEnd.Models.User.ResponseModel;
using AutoMapper;
using Business.Engine.Interfaces;
using Core.Common.DTOs.UserEngine;
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
            GetAllUserResponseDto getAllUserResponse = _userEngine.GetAllUser(_mapper.Map<UsersFilterParamsDto>(filter));

            return new GetAllUserResponseModel
            {
                Users = getAllUserResponse.Users,
                TotalRecords = getAllUserResponse.TotalRecords
            };
        }
    }
}