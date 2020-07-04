using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    public class PostTagRepository:EfCoreRepository<BlogDbContext,PostTag,int>,IPostTagRepository
    {
        public PostTagRepository(IDbContextProvider<BlogDbContext> dbContextProvider):base(dbContextProvider)
        {

        }

        public async Task BulkInsertAsync(IEnumerable<PostTag> postTags)
        {
            await DbContext.Set<PostTag>().AddRangeAsync(postTags);
            await DbContext.SaveChangesAsync();
        }
    }
}
