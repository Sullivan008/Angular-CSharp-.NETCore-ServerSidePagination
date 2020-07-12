using System.Collections.Generic;
using Core.Common.DTOs.UserService;

namespace Angular_ServerSidePagination_BackEnd.Models.User.ResponseModel
{
    public class GetAllUserResponseModel
    {
        public List<UserDto> Users { get; set; }

        public int TotalRecords { get; set; }
    }
}
