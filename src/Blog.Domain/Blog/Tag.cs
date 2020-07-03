using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Blog.Domain.Blog
{
    public class Tag:Entity<int>
    {
        public string  TagName { get; set; }
        public string DisplayName { get; set; }

    }
}
