// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IFileAttachmentRequest.
    /// </summary>
    public partial interface IFileAttachmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FileAttachment using PUT.
        /// </summary>
        /// <param name="fileAttachmentToCreate">The FileAttachment to create.</param>
        /// <returns>The created FileAttachment.</returns>
        Task<FileAttachment> CreateAsync(FileAttachment fileAttachmentToCreate);        /// <summary>
        /// Creates the specified FileAttachment using PUT.
        /// </summary>
        /// <param name="fileAttachmentToCreate">The FileAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileAttachment.</returns>
        Task<FileAttachment> CreateAsync(FileAttachment fileAttachmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified FileAttachment.
        /// </summary>
        /// <returns>The task to await.</returns>
        Task DeleteAsync();

        /// <summary>
        /// Deletes the specified FileAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified FileAttachment.
        /// </summary>
        /// <returns>The FileAttachment.</returns>
        Task<FileAttachment> GetAsync();

        /// <summary>
        /// Gets the specified FileAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileAttachment.</returns>
        Task<FileAttachment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified FileAttachment using PATCH.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment to update.</param>
        /// <returns>The updated FileAttachment.</returns>
        Task<FileAttachment> UpdateAsync(FileAttachment fileAttachmentToUpdate);

        /// <summary>
        /// Updates the specified FileAttachment using PATCH.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated FileAttachment.</returns>
        Task<FileAttachment> UpdateAsync(FileAttachment fileAttachmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Select(string value);

    }
}
