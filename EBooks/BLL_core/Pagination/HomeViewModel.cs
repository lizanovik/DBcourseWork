using BLL_core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_core.Pagination
{
    public class HomeViewModel
    {
        public List<ProductModel> Items { get; set; }
        public SortModel SortModel { get; set; }
        public Paginator PageViewModel { get; set; }
        public FilterModel FilterModel { get; set; }
    }
}
