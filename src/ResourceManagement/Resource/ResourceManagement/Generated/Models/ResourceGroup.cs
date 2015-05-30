using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.Rest;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// </summary>
    public partial class ResourceGroup
    {
        /// <summary>
        /// Gets or sets the location of the resource group. It cannot be
        /// changed after the resource group has been created. Has to be one
        /// of the supported Azure Locations, such as West US, East US, West
        /// Europe, East Asia, etc.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource group properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Gets or sets the tags attached to the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets resource group provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}