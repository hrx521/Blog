using Blog.Application.Contracts.Blog;
using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using Blog.ToolKits.Base;
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
        public async Task<ServiceResult> DeleteBlogAsync(int Id)
        {
            await this.posts.DeleteAsync(Id);
            return new ServiceResult();
        }

        public async Task<ServiceTResult<string>> InsertBlogAsync(PostDto dto)
        {
            var result = new ServiceTResult<string>();
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
            if (post == null)
            {
                result.IsFailed("添加失败");
                return result;
            }

            result.IsSuccess("添加成功");
            return result;
        }
        
        public async Task<ServiceTResult<PostDto>> GetBlogAsync(int Id)
        {
            var result = new ServiceTResult<PostDto>();
            var post = await this.posts.GetAsync(Id);
            if (post == null)
            {
                result.IsFailed("文章不存在");
                return result;
            }
            var postDto = new PostDto
            {
                Title = post.Title,
                Author = post.Author,
                Url = post.Url,
                Html = post.Html,
                Markdown = post.Markdown,
                CategoryId = post.CategoryId,
                CreationTime = post.CreationTime
            };
            result.IsSuccess(postDto);
            return result;
        }

        public async Task<ServiceTResult<string>> UpdateBlogAsync(int Id, PostDto dto)
        {
            var result = new ServiceTResult<string>();

            var post = await this.posts.GetAsync(Id);
            if(post==null)
            {
                result.IsFailed("指定ID的文章不存在");
                return result;
            }
            post.Title = dto.Title;
            post.Author = dto.Author;
            post.Url = dto.Url;
            post.Html = dto.Html;
            post.Markdown = dto.Markdown;
            post.CategoryId = dto.CategoryId;
            post.CreationTime = dto.CreationTime;

            await this.posts.UpdateAsync(post);

            result.IsSuccess("更新成功");
            return result;
        }
    }
}
