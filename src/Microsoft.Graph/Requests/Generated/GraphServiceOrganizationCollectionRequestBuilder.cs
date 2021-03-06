// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceOrganizationCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceOrganizationCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceOrganizationCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceOrganizationCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceOrganizationCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceOrganizationCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceOrganizationCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceOrganizationCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOrganizationRequestBuilder"/> for the specified GraphServiceOrganization.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceOrganization.</param>
        /// <returns>The <see cref="IOrganizationRequestBuilder"/>.</returns>
        public IOrganizationRequestBuilder this[string id]
        {
            get
            {
                return new OrganizationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
