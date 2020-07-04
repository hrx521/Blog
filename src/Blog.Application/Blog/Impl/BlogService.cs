using Blog.Application.Contracts.Blog;
using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Blog.Impl
{
    public class BlogService : ServiceBase,IBlogService
    {
        private readonly IPostRepository posts;

        public BlogService(IPostRepository posts)
        {
            this.posts = posts;
        }
        public async Task<bool> DeleteBlogAsync(int Id)
        {
            await this.posts.DeleteAsync(Id);
            return true;
        }

        public async Task<bool> InsertBlogAsync(PostDto dto)
        {
            var entity = new Post
            {
                Title = dto.Title,
                Author = dto.Author,
                Url = dto.Url,
                Html = dto.Html,
                Markdown = dto.Markdown,
                CategoryId = dto.CategoryId,
                CreationTime = dto.CreationTime
            };

            var post = await this.posts.InsertAsync(entity);
            return post != null;
        }
        
        public async Task<PostDto> GetBlogAsync(int Id)
        {
            var post = await this.posts.GetAsync(Id);
            return new PostDto
            {
                Title = post.Title,
                Author = post.Author,
                Url = post.Url,
                Html = post.Html,
                Markdown = post.Markdown,
                CategoryId = post.CategoryId,
                CreationTime = post.CreationTime
            };
        }

        public async Task<bool> UpdateBlogAsync(int Id, PostDto dto)
        {
            var post = await this.posts.GetAsync(Id);

            post.Title = dto.Title;
            post.Author = dto.Author;
            post.Url = dto.Url;
            post.Html = dto.Html;
            post.Markdown = dto.Markdown;
            post.CategoryId = dto.CategoryId;
            post.CreationTime = dto.CreationTime;

            await this.posts.UpdateAsync(post);

            return true;
        }
    }
}
