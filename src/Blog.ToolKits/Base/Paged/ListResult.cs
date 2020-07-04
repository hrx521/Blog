using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.ToolKits.Base.Paged
{
    public class ListResult<T> : IListResult<T>
    {
        private  IReadOnlyList<T> item;

        public IReadOnlyList<T> Item
        {
            get => this.item ?? (this.item=new List<T>());
            set => this.item = value;
        }
        public ListResult()
        {

        }
        public ListResult(IReadOnlyList<T> item)
        {
            Item = item;
        }
    }
}
