// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base class for fabric specific details of container.
    /// </summary>
    public partial class ProtectionContainerFabricSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerFabricSpecificDetails class.
        /// </summary>
        public ProtectionContainerFabricSpecificDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ProtectionContainerFabricSpecificDetails class.
        /// </summary>
        /// <param name="instanceType">Gets the class type. Overriden in
        /// derived classes.</param>
        public ProtectionContainerFabricSpecificDetails(string instanceType = default(string))
        {
            InstanceType = instanceType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the class type. Overriden in derived classes.
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; private set; }

    }
}