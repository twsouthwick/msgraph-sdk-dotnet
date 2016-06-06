// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DriveItemDeltaRequestBuilder.
    /// </summary>
    public partial class UserChangePasswordRequestBuilder : BasePostMethodRequestBuilder<IUserChangePasswordRequest>, IUserChangePasswordRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UserChangePasswordRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="currentPassword">A currentPassword parameter for the OData method call.</param>
        /// <param name="newPassword">A newPassword parameter for the OData method call.</param>
        public UserChangePasswordRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string currentPassword,
            string newPassword)
            : base(requestUrl, client)
        {
            SetParameter("currentPassword", currentPassword, true);
            SetParameter("newPassword", newPassword, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUserChangePasswordRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new UserChangePasswordRequest(functionUrl, this.Client, options);

            if (HasParameter("currentPassword"))
                request.RequestBody.CurrentPassword = GetParameter<string>("currentPassword");

            if (HasParameter("newPassword"))
                request.RequestBody.NewPassword = GetParameter<string>("newPassword");

            return request;
        }
    }
}
