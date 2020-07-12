using Angular_ServerSidePagination_BackEnd.Models;
using Angular_ServerSidePagination_BackEnd.Models.User.RequestModels;
using AutoMapper;
using Core.Common.DTOs;
using Core.Common.DTOs.UserEngine;

namespace Angular_ServerSidePagination_BackEnd.Profiles.User
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UsersFilterRequestModel, UsersFilterParamsDto>();
            CreateMap<SortModel, FilterParamSortDto>();
        }
    }
}
