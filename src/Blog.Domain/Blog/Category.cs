using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Blog.Domain.Blog
{
    public class Category:Entity<int>
    {
        public string CategoryName { get; set; }

        public string DisplayName { get; set; }

    }
}
