using System.Collections.Generic;

namespace Angular_ServerSidePagination_BackEnd.Models.User.RequestModels
{
    public class UsersFilterRequestModel
    {
        public int StartRow { get; set; }

        public int EndRow { get; set; }

        public IEnumerable<SortModel> SortModel { get; set; }
    }
}
