using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Blog.Domain.Blog
{
    public class PostTag:Entity<int>
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}
