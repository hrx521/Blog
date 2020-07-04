using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ToolKits.Base.Paged
{
    public interface IPagedList<T>:IListResult<T>,IHasTotalCount
    {

    }
}
