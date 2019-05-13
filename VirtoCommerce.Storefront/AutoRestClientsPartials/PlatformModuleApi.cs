using System;
using System.Net.Http;
using Microsoft.Extensions.Options;
using VirtoCommerce.Storefront.Infrastructure;
using VirtoCommerce.Storefront.Infrastructure.Autorest;

namespace VirtoCommerce.Storefront.AutoRestClients.PlatformModuleApi
{
    /// <summary>
    /// extention of AutoRest generated ServiceClient reailization to add ctr with HttpClient argument and get ctr with suitable view for AddHttpClient usage
    /// </summary>
    public partial class VirtoCommercePlatformRESTAPIdocumentationExtended : VirtoCommercePlatformRESTAPIdocumentation
    {
        public VirtoCommercePlatformRESTAPIdocumentationExtended(HttpClient httpClient, IOptions<PlatformEndpointOptions> options)
            : base(new EmptyServiceClientCredentials(), httpClient, false)
        {
            var platformEndpointOptions = options.Value ?? throw new ArgumentNullException(nameof(options));
            BaseUri = platformEndpointOptions.Url;
        }
    }
}
