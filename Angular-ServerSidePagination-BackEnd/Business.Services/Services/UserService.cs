using System;
using System.Collections.Generic;
using System.IO;
using Business.Service.Interfaces;
using Core.Common.DTOs.UserService;
using Newtonsoft.Json;

namespace Business.Service.Services
{
    public class UserService : IUserService
    {
        public List<UserDto> GetUsersMockData()
        {
            string usersJsonString = File.ReadAllText($@"{AppDomain.CurrentDomain.GetData("DataDirectory")}\MOCK_DATA.json");

            return JsonConvert.DeserializeObject<List<UserDto>>(usersJsonString);
        }
    }
}
