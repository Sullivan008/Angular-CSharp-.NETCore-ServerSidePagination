using System.Collections.Generic;

namespace Core.Common.DTOs.UserEngine
{
    public class UsersFilterParamsDto
    {
        public int StartRow { get; set; }

        public int EndRow { get; set; }

        public IEnumerable<FilterParamSortDto> SortModel { get; set; }
    }
}
