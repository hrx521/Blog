using Blog.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Blog.Domain.Blog.Repositories
{
    public interface ICategoryRepository:IRepository<Category,int>
    {
    }
}
