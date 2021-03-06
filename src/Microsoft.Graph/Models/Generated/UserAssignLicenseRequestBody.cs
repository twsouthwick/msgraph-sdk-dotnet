// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type UserAssignLicenseRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserAssignLicenseRequestBody
    {
    
        /// <summary>
        /// Gets or sets AddLicenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addLicenses", Required = Required.Default)]
        public IEnumerable<AssignedLicense> AddLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets RemoveLicenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "removeLicenses", Required = Required.Default)]
        public IEnumerable<Guid> RemoveLicenses { get; set; }
    
    }
}
