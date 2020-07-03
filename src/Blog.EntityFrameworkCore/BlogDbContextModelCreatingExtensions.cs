using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using System.Text;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Runtime.CompilerServices;
using static Blog.Domain.Shared.BlogDbConsts;
using Blog.Domain.Blog;
using Blog.Domain.Shared;

namespace Blog.EntityFrameworkCore
{
    public static class BlogDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));
            builder.Entity<Post>(b=>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Posts);
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(200).IsRequired();
                b.Property(x => x.Author).HasMaxLength(10);
                b.Property(x => x.Url).HasMaxLength(100).IsRequired();
                b.Property(x => x.Html).HasMaxLength(1024).IsRequired();
                b.Property(x => x.Markdown).HasMaxLength(1024).IsRequired();
                b.Property(x => x.CategoryId).HasColumnType("int");
                b.Property(x => x.CreationTime).HasColumnType("DateTime");
            });

            builder.Entity<Category>(b=>
            {
                b.ToTable(BlogConsts.DbTablePrefix+DbTableName.Categories);
                b.HasKey(x => x.Id);
                b.Property(x => x.CategoryName).HasMaxLength(64).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(64).IsRequired();
            });

            builder.Entity<Tag>(b=>
            {
                b.ToTable(BlogConsts.DbTablePrefix+DbTableName.Tags);
                b.HasKey(x => x.Id);
                b.Property(x => x.TagName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });

            builder.Entity<PostTag>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.PostTags);
                b.HasKey(x => x.Id);
                b.Property(x => x.PostId).HasColumnType("int").IsRequired();
                b.Property(x => x.TagId).HasColumnType("int").IsRequired();
            });

            builder.Entity<FriendLink>(b =>
            {
                b.ToTable(BlogConsts.DbTablePrefix + DbTableName.Friendlinks);
                b.HasKey(x => x.Id);
                b.Property(x => x.Title).HasMaxLength(20).IsRequired();
                b.Property(x => x.LinkUrl).HasMaxLength(100).IsRequired();
            });
        }
    }
}
