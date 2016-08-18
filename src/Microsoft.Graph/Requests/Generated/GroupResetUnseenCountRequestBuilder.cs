// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupResetUnseenCountRequestBuilder.
    /// </summary>
    public partial class GroupResetUnseenCountRequestBuilder : BaseFunctionMethodRequestBuilder<IGroupResetUnseenCountRequest>, IGroupResetUnseenCountRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="GroupResetUnseenCountRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GroupResetUnseenCountRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IGroupResetUnseenCountRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new GroupResetUnseenCountRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
