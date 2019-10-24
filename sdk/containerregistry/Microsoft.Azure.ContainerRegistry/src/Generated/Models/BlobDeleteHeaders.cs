// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class BlobDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the BlobDeleteHeaders class.
        /// </summary>
        public BlobDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobDeleteHeaders class.
        /// </summary>
        /// <param name="dockerContentDigest">Digest of the targeted content
        /// for the request.</param>
        public BlobDeleteHeaders(string dockerContentDigest = default(string))
        {
            DockerContentDigest = dockerContentDigest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets digest of the targeted content for the request.
        /// </summary>
        [JsonProperty(PropertyName = "Docker-Content-Digest")]
        public string DockerContentDigest { get; set; }

    }
}