// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Models
{
    using System.Linq;

    /// <summary>
    /// Server response for Get tenant groups API call
    /// </summary>
    public partial class GroupListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the GroupListResultInner class.
        /// </summary>
        public GroupListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the GroupListResultInner class.
        /// </summary>
        /// <param name="value">the list of groups.</param>
        /// <param name="odatanextLink">the URL to get the next set of
        /// results.</param>
        public GroupListResultInner(System.Collections.Generic.IList<ADGroupInner> value = default(System.Collections.Generic.IList<ADGroupInner>), string odatanextLink = default(string))
        {
            Value = value;
            OdatanextLink = odatanextLink;
        }

        /// <summary>
        /// Gets or sets the list of groups.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<ADGroupInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "odata.nextLink")]
        public string OdatanextLink { get; set; }

    }
}
