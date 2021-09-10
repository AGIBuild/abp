// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.MediaDescriptors;
using Volo.Abp.Content;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.MediaDescriptors.ClientProxies
{
    public partial class MediaDescriptorClientProxy
    {
        public virtual async Task<RemoteStreamContent> DownloadAsync(Guid id)
        {
            return await RequestAsync<RemoteStreamContent>(nameof(DownloadAsync), id);
        }
 
    }
}
