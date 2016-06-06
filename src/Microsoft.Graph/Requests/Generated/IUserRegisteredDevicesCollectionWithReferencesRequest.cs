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
    /// The interface IUserRegisteredDevicesCollectionWithReferencesRequest.
    /// </summary>
    public partial interface IUserRegisteredDevicesCollectionWithReferencesRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        Task<IUserRegisteredDevicesCollectionWithReferencesPage> GetAsync();
        
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        Task<IUserRegisteredDevicesCollectionWithReferencesPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IUserRegisteredDevicesCollectionWithReferencesRequest Top(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IUserRegisteredDevicesCollectionWithReferencesRequest OrderBy(string value);
    }
}
