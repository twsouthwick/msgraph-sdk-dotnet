// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type GraphServiceDirectoryRoleTemplatesCollectionRequest.
    /// </summary>
    public partial class GraphServiceDirectoryRoleTemplatesCollectionRequest : BaseRequest, IGraphServiceDirectoryRoleTemplatesCollectionRequest
    {
        /// <summary>
        /// Constructs a new GraphServiceDirectoryRoleTemplatesCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GraphServiceDirectoryRoleTemplatesCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        
        /// <summary>
        /// Adds the specified DirectoryRoleTemplate to the collection via POST.
        /// </summary>
        /// <param name="directoryRoleTemplate">The DirectoryRoleTemplate to add.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        public Task<DirectoryRoleTemplate> AddAsync(DirectoryRoleTemplate directoryRoleTemplate)
        {
            return this.AddAsync(directoryRoleTemplate, CancellationToken.None);
        }

        /// <summary>
        /// Adds the specified DirectoryRoleTemplate to the collection via POST.
        /// </summary>
        /// <param name="directoryRoleTemplate">The DirectoryRoleTemplate to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRoleTemplate.</returns>
        public Task<DirectoryRoleTemplate> AddAsync(DirectoryRoleTemplate directoryRoleTemplate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            return this.SendAsync<DirectoryRoleTemplate>(directoryRoleTemplate, cancellationToken);
        }
  
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        public Task<IGraphServiceDirectoryRoleTemplatesCollectionPage> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async Task<IGraphServiceDirectoryRoleTemplatesCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var response = await this.SendAsync<GraphServiceDirectoryRoleTemplatesCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                    
                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IGraphServiceDirectoryRoleTemplatesCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
