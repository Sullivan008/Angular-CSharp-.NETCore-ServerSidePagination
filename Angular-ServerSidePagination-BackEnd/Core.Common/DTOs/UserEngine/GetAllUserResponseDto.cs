using System.Collections.Generic;
using Core.Common.DTOs.UserService;

namespace Core.Common.DTOs.UserEngine
{
    public class GetAllUserResponseDto
    {
        public List<UserDto> Users { get; set; }

        public int TotalRecords { get; set; }
    }
}
