using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_core.Pagination
{
    public class FilterModel
    {
        public string CurrentSearch;
        public FilterModel(string search)
        {
            CurrentSearch = search;
        }
    }
}
