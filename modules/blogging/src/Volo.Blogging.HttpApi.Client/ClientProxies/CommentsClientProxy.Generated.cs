// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Blogging.Comments;
using System.Collections.Generic;
using Volo.Blogging.Comments.Dtos;

// ReSharper disable once CheckNamespace
namespace Volo.Blogging.ClientProxies
{
    public partial class CommentsClientProxy
    {
        public virtual async Task<List<CommentWithRepliesDto>> GetHierarchicalListOfPostAsync(Guid postId)
        {
            return await RequestAsync<List<CommentWithRepliesDto>>(nameof(GetHierarchicalListOfPostAsync), postId);
        }
 
        public virtual async Task<CommentWithDetailsDto> CreateAsync(CreateCommentDto input)
        {
            return await RequestAsync<CommentWithDetailsDto>(nameof(CreateAsync), input);
        }
 
        public virtual async Task<CommentWithDetailsDto> UpdateAsync(Guid id, UpdateCommentDto input)
        {
            return await RequestAsync<CommentWithDetailsDto>(nameof(UpdateAsync), id, input);
        }
 
        public virtual async Task DeleteAsync(Guid id)
        {
            await RequestAsync(nameof(DeleteAsync), id);
        }
 
    }
}
