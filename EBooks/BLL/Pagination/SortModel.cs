using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Pagination
{
    public enum SortState
    {
        Price,
        Firm
    }

    public enum SortOrder
    {
        Asc,
        Desc
    }
    public class SortModel
    {

        public SortState CurrentSort { get; set; }
        public SortOrder SortOrder { get; set; }
        public SortOrder CurrentOrder { get; set; }

        public SortModel(SortState sortBy, SortOrder sortOrder)
        {
            SortOrder = sortOrder == SortOrder.Asc ? SortOrder.Desc : SortOrder.Asc;
            CurrentSort = sortBy;
            CurrentOrder = sortOrder;
        }
    }
}
