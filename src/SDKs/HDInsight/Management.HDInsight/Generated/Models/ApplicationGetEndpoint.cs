// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Gets the application SSH endpoint
    /// </summary>
    public partial class ApplicationGetEndpoint
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGetEndpoint class.
        /// </summary>
        public ApplicationGetEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGetEndpoint class.
        /// </summary>
        /// <param name="location">The location of the endpoint.</param>
        /// <param name="destinationPort">The destination port to connect
        /// to.</param>
        /// <param name="publicPort">The public port to connect to.</param>
        public ApplicationGetEndpoint(string location = default(string), int? destinationPort = default(int?), int? publicPort = default(int?))
        {
            Location = location;
            DestinationPort = destinationPort;
            PublicPort = publicPort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the destination port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPort")]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Gets or sets the public port to connect to.
        /// </summary>
        [JsonProperty(PropertyName = "publicPort")]
        public int? PublicPort { get; set; }

    }
}