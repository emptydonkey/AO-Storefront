using System;
using System.Net.Http;
using Microsoft.Extensions.Options;
using VirtoCommerce.Storefront.Infrastructure;
using VirtoCommerce.Storefront.Infrastructure.Autorest;

namespace VirtoCommerce.Storefront.AutoRestClients.ContentModuleApi
{
    /// <summary>
    /// partial extention of AutoRest generated ServiceClient reailization for adding of ctr with HttpClient argument
    /// </summary>
    public partial class VirtoCommerceContentRESTAPIdocumentationExtended : VirtoCommerceContentRESTAPIdocumentation
    {
        public VirtoCommerceContentRESTAPIdocumentationExtended(HttpClient httpClient, IOptions<PlatformEndpointOptions> options)
            : base(new EmptyServiceClientCredentials(), httpClient, false)
        {
            var platformEndpointOptions = options.Value ?? throw new ArgumentNullException(nameof(options));
            BaseUri = platformEndpointOptions.Url;
        }
    }
}
